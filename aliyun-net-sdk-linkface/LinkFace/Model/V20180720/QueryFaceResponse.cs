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

namespace Aliyun.Acs.LinkFace.Model.V20180720
{
	public class QueryFaceResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private string message;

		private bool? success;

		private QueryFace_Data data;

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

		public int? Code
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public QueryFace_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class QueryFace_Data
		{

			private List<QueryFace_UserFaceMetasItem> userFaceMetas;

			private List<string> groupIds;

			public List<QueryFace_UserFaceMetasItem> UserFaceMetas
			{
				get
				{
					return userFaceMetas;
				}
				set	
				{
					userFaceMetas = value;
				}
			}

			public List<string> GroupIds
			{
				get
				{
					return groupIds;
				}
				set	
				{
					groupIds = value;
				}
			}

			public class QueryFace_UserFaceMetasItem
			{

				private string clientTag;

				private int? index;

				private string faceUrl;

				private string userInfo;

				public string ClientTag
				{
					get
					{
						return clientTag;
					}
					set	
					{
						clientTag = value;
					}
				}

				public int? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public string FaceUrl
				{
					get
					{
						return faceUrl;
					}
					set	
					{
						faceUrl = value;
					}
				}

				public string UserInfo
				{
					get
					{
						return userInfo;
					}
					set	
					{
						userInfo = value;
					}
				}
			}
		}
	}
}