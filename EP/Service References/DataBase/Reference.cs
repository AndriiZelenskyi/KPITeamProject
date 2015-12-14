﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EP.DataBase {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataBase.IDataBase")]
    public interface IDataBase {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/Authorizate", ReplyAction="http://tempuri.org/IDataBase/AuthorizateResponse")]
        int Authorizate(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/Authorizate", ReplyAction="http://tempuri.org/IDataBase/AuthorizateResponse")]
        System.Threading.Tasks.Task<int> AuthorizateAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/Registration", ReplyAction="http://tempuri.org/IDataBase/RegistrationResponse")]
        int Registration(string username, string password, string firstname, string secondname, string programmingLanguage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/Registration", ReplyAction="http://tempuri.org/IDataBase/RegistrationResponse")]
        System.Threading.Tasks.Task<int> RegistrationAsync(string username, string password, string firstname, string secondname, string programmingLanguage);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetUserFriends", ReplyAction="http://tempuri.org/IDataBase/GetUserFriendsResponse")]
        int[] GetUserFriends(int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetUserFriends", ReplyAction="http://tempuri.org/IDataBase/GetUserFriendsResponse")]
        System.Threading.Tasks.Task<int[]> GetUserFriendsAsync(int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetUser", ReplyAction="http://tempuri.org/IDataBase/GetUserResponse")]
        string[] GetUser(int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetUser", ReplyAction="http://tempuri.org/IDataBase/GetUserResponse")]
        System.Threading.Tasks.Task<string[]> GetUserAsync(int idUser);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetUserByLogin", ReplyAction="http://tempuri.org/IDataBase/GetUserByLoginResponse")]
        string[] GetUserByLogin(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetUserByLogin", ReplyAction="http://tempuri.org/IDataBase/GetUserByLoginResponse")]
        System.Threading.Tasks.Task<string[]> GetUserByLoginAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/AnswerCheck", ReplyAction="http://tempuri.org/IDataBase/AnswerCheckResponse")]
        string[] AnswerCheck(int id, string source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/AnswerCheck", ReplyAction="http://tempuri.org/IDataBase/AnswerCheckResponse")]
        System.Threading.Tasks.Task<string[]> AnswerCheckAsync(int id, string source);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/TaskList", ReplyAction="http://tempuri.org/IDataBase/TaskListResponse")]
        System.Collections.Generic.Dictionary<int, string[]> TaskList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/TaskList", ReplyAction="http://tempuri.org/IDataBase/TaskListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string[]>> TaskListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/AddTask", ReplyAction="http://tempuri.org/IDataBase/AddTaskResponse")]
        int AddTask(string[] task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/AddTask", ReplyAction="http://tempuri.org/IDataBase/AddTaskResponse")]
        System.Threading.Tasks.Task<int> AddTaskAsync(string[] task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/SendMessage", ReplyAction="http://tempuri.org/IDataBase/SendMessageResponse")]
        void SendMessage(int firstid, int secondid, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/SendMessage", ReplyAction="http://tempuri.org/IDataBase/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(int firstid, int secondid, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetMessage", ReplyAction="http://tempuri.org/IDataBase/GetMessageResponse")]
        string GetMessage(int firstid, int secondid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/GetMessage", ReplyAction="http://tempuri.org/IDataBase/GetMessageResponse")]
        System.Threading.Tasks.Task<string> GetMessageAsync(int firstid, int secondid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/DeleteFriend", ReplyAction="http://tempuri.org/IDataBase/DeleteFriendResponse")]
        void DeleteFriend(int first_id, int second_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/DeleteFriend", ReplyAction="http://tempuri.org/IDataBase/DeleteFriendResponse")]
        System.Threading.Tasks.Task DeleteFriendAsync(int first_id, int second_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/AddFriend", ReplyAction="http://tempuri.org/IDataBase/AddFriendResponse")]
        void AddFriend(int first_id, int second_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataBase/AddFriend", ReplyAction="http://tempuri.org/IDataBase/AddFriendResponse")]
        System.Threading.Tasks.Task AddFriendAsync(int first_id, int second_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataBaseChannel : EP.DataBase.IDataBase, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataBaseClient : System.ServiceModel.ClientBase<EP.DataBase.IDataBase>, EP.DataBase.IDataBase {
        
        public DataBaseClient() {
        }
        
        public DataBaseClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataBaseClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataBaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataBaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Authorizate(string username, string password) {
            return base.Channel.Authorizate(username, password);
        }
        
        public System.Threading.Tasks.Task<int> AuthorizateAsync(string username, string password) {
            return base.Channel.AuthorizateAsync(username, password);
        }
        
        public int Registration(string username, string password, string firstname, string secondname, string programmingLanguage) {
            return base.Channel.Registration(username, password, firstname, secondname, programmingLanguage);
        }
        
        public System.Threading.Tasks.Task<int> RegistrationAsync(string username, string password, string firstname, string secondname, string programmingLanguage) {
            return base.Channel.RegistrationAsync(username, password, firstname, secondname, programmingLanguage);
        }
        
        public int[] GetUserFriends(int idUser) {
            return base.Channel.GetUserFriends(idUser);
        }
        
        public System.Threading.Tasks.Task<int[]> GetUserFriendsAsync(int idUser) {
            return base.Channel.GetUserFriendsAsync(idUser);
        }
        
        public string[] GetUser(int idUser) {
            return base.Channel.GetUser(idUser);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUserAsync(int idUser) {
            return base.Channel.GetUserAsync(idUser);
        }
        
        public string[] GetUserByLogin(string login) {
            return base.Channel.GetUserByLogin(login);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUserByLoginAsync(string login) {
            return base.Channel.GetUserByLoginAsync(login);
        }
        
        public string[] AnswerCheck(int id, string source) {
            return base.Channel.AnswerCheck(id, source);
        }
        
        public System.Threading.Tasks.Task<string[]> AnswerCheckAsync(int id, string source) {
            return base.Channel.AnswerCheckAsync(id, source);
        }
        
        public System.Collections.Generic.Dictionary<int, string[]> TaskList() {
            return base.Channel.TaskList();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<int, string[]>> TaskListAsync() {
            return base.Channel.TaskListAsync();
        }
        
        public int AddTask(string[] task) {
            return base.Channel.AddTask(task);
        }
        
        public System.Threading.Tasks.Task<int> AddTaskAsync(string[] task) {
            return base.Channel.AddTaskAsync(task);
        }
        
        public void SendMessage(int firstid, int secondid, string message) {
            base.Channel.SendMessage(firstid, secondid, message);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(int firstid, int secondid, string message) {
            return base.Channel.SendMessageAsync(firstid, secondid, message);
        }
        
        public string GetMessage(int firstid, int secondid) {
            return base.Channel.GetMessage(firstid, secondid);
        }
        
        public System.Threading.Tasks.Task<string> GetMessageAsync(int firstid, int secondid) {
            return base.Channel.GetMessageAsync(firstid, secondid);
        }
        
        public void DeleteFriend(int first_id, int second_id) {
            base.Channel.DeleteFriend(first_id, second_id);
        }
        
        public System.Threading.Tasks.Task DeleteFriendAsync(int first_id, int second_id) {
            return base.Channel.DeleteFriendAsync(first_id, second_id);
        }
        
        public void AddFriend(int first_id, int second_id) {
            base.Channel.AddFriend(first_id, second_id);
        }
        
        public System.Threading.Tasks.Task AddFriendAsync(int first_id, int second_id) {
            return base.Channel.AddFriendAsync(first_id, second_id);
        }
    }
}
