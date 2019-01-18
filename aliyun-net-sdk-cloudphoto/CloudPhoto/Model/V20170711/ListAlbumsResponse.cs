/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
	public class ListAlbumsResponse : AcsResponse
	{

		private string code;

		private string message;

		private string nextCursor;

		private int? totalCount;

		private string requestId;

		private string action;

		private List<ListAlbums_Album> albums;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string NextCursor
		{
			get
			{
				return nextCursor;
			}
			set	
			{
				nextCursor = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
			}
		}

		public List<ListAlbums_Album> Albums
		{
			get
			{
				return albums;
			}
			set	
			{
				albums = value;
			}
		}

		public class ListAlbums_Album
		{

			private long? id;

			private string idStr;

			private string name;

			private string state;

			private string remark;

			private long? photosCount;

			private long? ctime;

			private long? mtime;

			private ListAlbums_Cover cover;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string IdStr
			{
				get
				{
					return idStr;
				}
				set	
				{
					idStr = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public long? PhotosCount
			{
				get
				{
					return photosCount;
				}
				set	
				{
					photosCount = value;
				}
			}

			public long? Ctime
			{
				get
				{
					return ctime;
				}
				set	
				{
					ctime = value;
				}
			}

			public long? Mtime
			{
				get
				{
					return mtime;
				}
				set	
				{
					mtime = value;
				}
			}

			public ListAlbums_Cover Cover
			{
				get
				{
					return cover;
				}
				set	
				{
					cover = value;
				}
			}

			public class ListAlbums_Cover
			{

				private long? id;

				private string idStr;

				private string title;

				private string fileId;

				private string state;

				private string md5;

				private bool? isVideo;

				private string remark;

				private long? width;

				private long? height;

				private long? ctime;

				private long? mtime;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string IdStr
				{
					get
					{
						return idStr;
					}
					set	
					{
						idStr = value;
					}
				}

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public string FileId
				{
					get
					{
						return fileId;
					}
					set	
					{
						fileId = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string Md5
				{
					get
					{
						return md5;
					}
					set	
					{
						md5 = value;
					}
				}

				public bool? IsVideo
				{
					get
					{
						return isVideo;
					}
					set	
					{
						isVideo = value;
					}
				}

				public string Remark
				{
					get
					{
						return remark;
					}
					set	
					{
						remark = value;
					}
				}

				public long? Width
				{
					get
					{
						return width;
					}
					set	
					{
						width = value;
					}
				}

				public long? Height
				{
					get
					{
						return height;
					}
					set	
					{
						height = value;
					}
				}

				public long? Ctime
				{
					get
					{
						return ctime;
					}
					set	
					{
						ctime = value;
					}
				}

				public long? Mtime
				{
					get
					{
						return mtime;
					}
					set	
					{
						mtime = value;
					}
				}
			}
		}
	}
}