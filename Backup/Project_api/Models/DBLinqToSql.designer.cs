﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_api.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="projectDB")]
	public partial class DBLinqToSqlDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    partial void InsertMove(Move instance);
    partial void UpdateMove(Move instance);
    partial void DeleteMove(Move instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DBLinqToSqlDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["projectDBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBLinqToSqlDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLinqToSqlDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLinqToSqlDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBLinqToSqlDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
		
		public System.Data.Linq.Table<Move> Moves
		{
			get
			{
				return this.GetTable<Move>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Games")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _gameId;
		
		private string _gameName;
		
		private System.Nullable<System.Guid> _player1Id;
		
		private System.Nullable<System.Guid> _Player2Id;
		
		private System.Nullable<int> _matchStartCount;
		
		private System.Nullable<int> _matchRoundCount;
		
		private EntitySet<Move> _Moves;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OngameIdChanging(System.Guid value);
    partial void OngameIdChanged();
    partial void OngameNameChanging(string value);
    partial void OngameNameChanged();
    partial void Onplayer1IdChanging(System.Nullable<System.Guid> value);
    partial void Onplayer1IdChanged();
    partial void OnPlayer2IdChanging(System.Nullable<System.Guid> value);
    partial void OnPlayer2IdChanged();
    partial void OnmatchStartCountChanging(System.Nullable<int> value);
    partial void OnmatchStartCountChanged();
    partial void OnmatchRoundCountChanging(System.Nullable<int> value);
    partial void OnmatchRoundCountChanged();
    #endregion
		
		public Game()
		{
			this._Moves = new EntitySet<Move>(new Action<Move>(this.attach_Moves), new Action<Move>(this.detach_Moves));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gameId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid gameId
		{
			get
			{
				return this._gameId;
			}
			set
			{
				if ((this._gameId != value))
				{
					this.OngameIdChanging(value);
					this.SendPropertyChanging();
					this._gameId = value;
					this.SendPropertyChanged("gameId");
					this.OngameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gameName", DbType="NVarChar(50)")]
		public string gameName
		{
			get
			{
				return this._gameName;
			}
			set
			{
				if ((this._gameName != value))
				{
					this.OngameNameChanging(value);
					this.SendPropertyChanging();
					this._gameName = value;
					this.SendPropertyChanged("gameName");
					this.OngameNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_player1Id", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> player1Id
		{
			get
			{
				return this._player1Id;
			}
			set
			{
				if ((this._player1Id != value))
				{
					this.Onplayer1IdChanging(value);
					this.SendPropertyChanging();
					this._player1Id = value;
					this.SendPropertyChanged("player1Id");
					this.Onplayer1IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Player2Id", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> Player2Id
		{
			get
			{
				return this._Player2Id;
			}
			set
			{
				if ((this._Player2Id != value))
				{
					this.OnPlayer2IdChanging(value);
					this.SendPropertyChanging();
					this._Player2Id = value;
					this.SendPropertyChanged("Player2Id");
					this.OnPlayer2IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matchStartCount", DbType="Int")]
		public System.Nullable<int> matchStartCount
		{
			get
			{
				return this._matchStartCount;
			}
			set
			{
				if ((this._matchStartCount != value))
				{
					this.OnmatchStartCountChanging(value);
					this.SendPropertyChanging();
					this._matchStartCount = value;
					this.SendPropertyChanged("matchStartCount");
					this.OnmatchStartCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_matchRoundCount", DbType="Int")]
		public System.Nullable<int> matchRoundCount
		{
			get
			{
				return this._matchRoundCount;
			}
			set
			{
				if ((this._matchRoundCount != value))
				{
					this.OnmatchRoundCountChanging(value);
					this.SendPropertyChanging();
					this._matchRoundCount = value;
					this.SendPropertyChanged("matchRoundCount");
					this.OnmatchRoundCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_Move", Storage="_Moves", ThisKey="gameId", OtherKey="movesGameId")]
		public EntitySet<Move> Moves
		{
			get
			{
				return this._Moves;
			}
			set
			{
				this._Moves.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Moves(Move entity)
		{
			this.SendPropertyChanging();
			entity.Game = this;
		}
		
		private void detach_Moves(Move entity)
		{
			this.SendPropertyChanging();
			entity.Game = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Moves")]
	public partial class Move : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _movesGameId;
		
		private int _moveNumber;
		
		private System.Nullable<System.Guid> _movePlayer;
		
		private System.Nullable<int> _moveMatchCount;
		
		private int _actualMatchCount;
		
		private EntityRef<Game> _Game;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnmovesGameIdChanging(System.Guid value);
    partial void OnmovesGameIdChanged();
    partial void OnmoveNumberChanging(int value);
    partial void OnmoveNumberChanged();
    partial void OnmovePlayerChanging(System.Nullable<System.Guid> value);
    partial void OnmovePlayerChanged();
    partial void OnmoveMatchCountChanging(System.Nullable<int> value);
    partial void OnmoveMatchCountChanged();
    partial void OnactualMatchCountChanging(int value);
    partial void OnactualMatchCountChanged();
    #endregion
		
		public Move()
		{
			this._Game = default(EntityRef<Game>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_movesGameId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid movesGameId
		{
			get
			{
				return this._movesGameId;
			}
			set
			{
				if ((this._movesGameId != value))
				{
					if (this._Game.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnmovesGameIdChanging(value);
					this.SendPropertyChanging();
					this._movesGameId = value;
					this.SendPropertyChanged("movesGameId");
					this.OnmovesGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_moveNumber", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int moveNumber
		{
			get
			{
				return this._moveNumber;
			}
			set
			{
				if ((this._moveNumber != value))
				{
					this.OnmoveNumberChanging(value);
					this.SendPropertyChanging();
					this._moveNumber = value;
					this.SendPropertyChanged("moveNumber");
					this.OnmoveNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_movePlayer", DbType="UniqueIdentifier")]
		public System.Nullable<System.Guid> movePlayer
		{
			get
			{
				return this._movePlayer;
			}
			set
			{
				if ((this._movePlayer != value))
				{
					this.OnmovePlayerChanging(value);
					this.SendPropertyChanging();
					this._movePlayer = value;
					this.SendPropertyChanged("movePlayer");
					this.OnmovePlayerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_moveMatchCount", DbType="Int")]
		public System.Nullable<int> moveMatchCount
		{
			get
			{
				return this._moveMatchCount;
			}
			set
			{
				if ((this._moveMatchCount != value))
				{
					this.OnmoveMatchCountChanging(value);
					this.SendPropertyChanging();
					this._moveMatchCount = value;
					this.SendPropertyChanged("moveMatchCount");
					this.OnmoveMatchCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_actualMatchCount", DbType="Int")]
		public int actualMatchCount
		{
			get
			{
				return this._actualMatchCount;
			}
			set
			{
				if ((this._actualMatchCount != value))
				{
					this.OnactualMatchCountChanging(value);
					this.SendPropertyChanging();
					this._actualMatchCount = value;
					this.SendPropertyChanged("actualMatchCount");
					this.OnactualMatchCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_Move", Storage="_Game", ThisKey="movesGameId", OtherKey="gameId", IsForeignKey=true)]
		public Game Game
		{
			get
			{
				return this._Game.Entity;
			}
			set
			{
				Game previousValue = this._Game.Entity;
				if (((previousValue != value) 
							|| (this._Game.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Game.Entity = null;
						previousValue.Moves.Remove(this);
					}
					this._Game.Entity = value;
					if ((value != null))
					{
						value.Moves.Add(this);
						this._movesGameId = value.gameId;
					}
					else
					{
						this._movesGameId = default(System.Guid);
					}
					this.SendPropertyChanged("Game");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _userId;
		
		private string _userEmail;
		
		private string _userName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(System.Guid value);
    partial void OnuserIdChanged();
    partial void OnuserEmailChanging(string value);
    partial void OnuserEmailChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userEmail", DbType="NVarChar(400) NOT NULL", CanBeNull=false)]
		public string userEmail
		{
			get
			{
				return this._userEmail;
			}
			set
			{
				if ((this._userEmail != value))
				{
					this.OnuserEmailChanging(value);
					this.SendPropertyChanging();
					this._userEmail = value;
					this.SendPropertyChanged("userEmail");
					this.OnuserEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="NVarChar(50)")]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
