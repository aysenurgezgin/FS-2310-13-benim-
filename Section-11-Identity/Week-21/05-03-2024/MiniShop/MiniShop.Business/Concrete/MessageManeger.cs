using AutoMapper;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Business.Concrete
{ 
    public class MessageManeger : IMessageService
    {
        private readonly IMapper _mapper;
        private readonly IMessageService _repository;
        private CategoryViewModel createdMessageDetailsViewModel;

        public MessageManeger(IMapper mapper, IMessageService messageRepository)
        {
            _mapper = mapper;
            _repository = messageRepository;
        }

        public async Task<Response<MessageDeatilsViewModel>> CreateAsync(MessageDeatilsViewModel messageDeatilsViewModel)
        {
            var message = _mapper.Map<Message>(messageDeatilsViewModel);
            var createdMessage = await _repository.CreateAsync(message);
            if (createdMessage == null)
            {
                return Response<MessageDeatilsViewModel>.Fail("Mesaj gönderilemedi");
            }
            var createdCMessageDetailsViewModel = _mapper.Map<MessageDeatilsViewModel>(createdMessage);
            return Response<MessageDeatilsViewModel>.Success(createdMessageDetailsViewModel);
        }

        public Task CreateAsync(Category message)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Message message)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<MessageDeatilsViewModel>>> GetAllAsync(string userId, bool isRead = true)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<MessageDeatilsViewModel>>> GetAllReceivedMessageAsync(string userId, bool isRead = false)
        {

            var messageList = await _repository.GetAllAsync(x => x.FromId == userId && x.IsRead = isRead);
            if (messageList.Count == 0)
            {
                var infoText = isRead ? "Okunmuş" : "Okunmamış";
                return Response<List<MessageDeatilsViewModel>>.Fail($"{infoText}mesajınız bulunmamaktadır.");
            }
            var categoryViewModelList = _mapper.Map<List<CategoryViewModel>>(messageList);
            return Response<List<CategoryViewModel>>.Success(messageViewModel);
        }

        public async Task<Response<List<MessageDeatilsViewModel>>> GetAllSentMessageAsync(string userId)
        {

            var messageList = await _repository.GetAllAsync(x => x.FromId == userId && x.IsRead = isRead);
            if (messageList.Count == 0)
            {
                return Response<List<MessageViewModel>>.Fail("Giden kutusu boş");
            }
            var categoryViewModelList = _mapper.Map<List<CategoryViewModel>>(messageList);
            return Response<List<CategoryViewModel>>.Success(messageViewModel);
        }

        public async Task<Response<MessageDeatilsViewModel>> GetByIdAsync(int id)
        {
            var message = await _repository.GetByIdAsync(x => x.Id == id);
            if (message == null)
            {
                return Response<MessageDeatilsViewModel>.Fail("Mesaj açılmadı");
            }
            var messageViewModel = _mapper.Map<MessageDeatilsViewModel>(message);
            return Response<MessageDeatilsViewModel>.Success(categoryViewModel);
        }

        public async Task<Response<int>> GetMessageCount(string userId, bool isRead = false)
        {
            var count = await _repository.GetCount(x => x.FromId &&);
            return Response<int>.Success(count);
        }

        public Task<Response<NoContent>> HardDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
