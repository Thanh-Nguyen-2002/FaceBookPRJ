using System;
using System.Collections.Generic;

namespace Fabook.Models
{
    public partial class User
    {
        public User()
        {
            BlockedUserBlockeds = new HashSet<BlockedUser>();
            BlockedUserBlockers = new HashSet<BlockedUser>();
            ChatGroupMembers = new HashSet<ChatGroupMember>();
            ChatGroupMessages = new HashSet<ChatGroupMessage>();
            ChatGroups = new HashSet<ChatGroup>();
            Comments = new HashSet<Comment>();
            FollowFollowers = new HashSet<Follow>();
            FollowFollowings = new HashSet<Follow>();
            FriendFriendNavigations = new HashSet<Friend>();
            FriendUsers = new HashSet<Friend>();
            GroupMembers = new HashSet<GroupMember>();
            GroupPosts = new HashSet<GroupPost>();
            Groups = new HashSet<Group>();
            Mentions = new HashSet<Mention>();
            MessageReceivers = new HashSet<Message>();
            MessageSenders = new HashSet<Message>();
            Notifications = new HashSet<Notification>();
            Posts = new HashSet<Post>();
            Reactions = new HashSet<Reaction>();
            ReportReporteds = new HashSet<Report>();
            ReportReporters = new HashSet<Report>();
            SavedPosts = new HashSet<SavedPost>();
            Shares = new HashSet<Share>();
            Tokens = new HashSet<Token>();
            VideoComments = new HashSet<VideoComment>();
            VideoReactions = new HashSet<VideoReaction>();
            VideoViews = new HashSet<VideoView>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? FullName { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsActive { get; set; }

        public virtual PrivacySetting? PrivacySetting { get; set; }
        public virtual ICollection<BlockedUser> BlockedUserBlockeds { get; set; }
        public virtual ICollection<BlockedUser> BlockedUserBlockers { get; set; }
        public virtual ICollection<ChatGroupMember> ChatGroupMembers { get; set; }
        public virtual ICollection<ChatGroupMessage> ChatGroupMessages { get; set; }
        public virtual ICollection<ChatGroup> ChatGroups { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Follow> FollowFollowers { get; set; }
        public virtual ICollection<Follow> FollowFollowings { get; set; }
        public virtual ICollection<Friend> FriendFriendNavigations { get; set; }
        public virtual ICollection<Friend> FriendUsers { get; set; }
        public virtual ICollection<GroupMember> GroupMembers { get; set; }
        public virtual ICollection<GroupPost> GroupPosts { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Mention> Mentions { get; set; }
        public virtual ICollection<Message> MessageReceivers { get; set; }
        public virtual ICollection<Message> MessageSenders { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Reaction> Reactions { get; set; }
        public virtual ICollection<Report> ReportReporteds { get; set; }
        public virtual ICollection<Report> ReportReporters { get; set; }
        public virtual ICollection<SavedPost> SavedPosts { get; set; }
        public virtual ICollection<Share> Shares { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
        public virtual ICollection<VideoComment> VideoComments { get; set; }
        public virtual ICollection<VideoReaction> VideoReactions { get; set; }
        public virtual ICollection<VideoView> VideoViews { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
