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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class CreateAppRequest : RpcAcsRequest<CreateAppResponse>
    {
        public CreateAppRequest()
            : base("retailcloud", "2018-03-13", "CreateApp", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string bizTitle;

		private string operatingSystem;

		private string description;

		private string language;

		private string title;

		private List<int?> middleWareIdLists = new List<int?>(){ };

		private int? stateType;

		private string serviceType;

		private List<UserRoles> userRoless = new List<UserRoles>(){ };

		private string bizCode;

		private string _namespace;

		public string BizTitle
		{
			get
			{
				return bizTitle;
			}
			set	
			{
				bizTitle = value;
				DictionaryUtil.Add(BodyParameters, "BizTitle", value);
			}
		}

		public string OperatingSystem
		{
			get
			{
				return operatingSystem;
			}
			set	
			{
				operatingSystem = value;
				DictionaryUtil.Add(BodyParameters, "OperatingSystem", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string Language
		{
			get
			{
				return language;
			}
			set	
			{
				language = value;
				DictionaryUtil.Add(BodyParameters, "Language", value);
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
				DictionaryUtil.Add(BodyParameters, "Title", value);
			}
		}

		public List<int?> MiddleWareIdLists
		{
			get
			{
				return middleWareIdLists;
			}

			set
			{
				middleWareIdLists = value;
				for (int i = 0; i < middleWareIdLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"MiddleWareIdList." + (i + 1) , middleWareIdLists[i]);
				}
			}
		}

		public int? StateType
		{
			get
			{
				return stateType;
			}
			set	
			{
				stateType = value;
				DictionaryUtil.Add(BodyParameters, "StateType", value.ToString());
			}
		}

		public string ServiceType
		{
			get
			{
				return serviceType;
			}
			set	
			{
				serviceType = value;
				DictionaryUtil.Add(BodyParameters, "ServiceType", value);
			}
		}

		public List<UserRoles> UserRoless
		{
			get
			{
				return userRoless;
			}

			set
			{
				userRoless = value;
				for (int i = 0; i < userRoless.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"UserRoles." + (i + 1) + ".RoleName", userRoless[i].RoleName);
					DictionaryUtil.Add(BodyParameters,"UserRoles." + (i + 1) + ".UserType", userRoless[i].UserType);
					DictionaryUtil.Add(BodyParameters,"UserRoles." + (i + 1) + ".UserId", userRoless[i].UserId);
				}
			}
		}

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
				DictionaryUtil.Add(BodyParameters, "BizCode", value);
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(BodyParameters, "Namespace", value);
			}
		}

		public class UserRoles
		{

			private string roleName;

			private string userType;

			private string userId;

			public string RoleName
			{
				get
				{
					return roleName;
				}
				set	
				{
					roleName = value;
				}
			}

			public string UserType
			{
				get
				{
					return userType;
				}
				set	
				{
					userType = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAppResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAppResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
