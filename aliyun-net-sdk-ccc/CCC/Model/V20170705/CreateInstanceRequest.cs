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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class CreateInstanceRequest : RpcAcsRequest<CreateInstanceResponse>
    {
        public CreateInstanceRequest()
            : base("CCC", "2017-07-05", "CreateInstance")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<string> phoneNumberss = new List<string>(){ };

		private List<string> userObjects = new List<string>(){ };

		private string domainName;

		private string phoneNumber;

		private string description;

		private int? storageMaxDays;

		private List<string> adminRamIds = new List<string>(){ };

		private string name;

		private int? storageMaxSize;

		private string directoryId;

		public List<string> PhoneNumberss
		{
			get
			{
				return phoneNumberss;
			}

			set
			{
				phoneNumberss = value;
				for (int i = 0; i < phoneNumberss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PhoneNumbers." + (i + 1) , phoneNumberss[i]);
				}
			}
		}

		public List<string> UserObjects
		{
			get
			{
				return userObjects;
			}

			set
			{
				userObjects = value;
				for (int i = 0; i < userObjects.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserObject." + (i + 1) , userObjects[i]);
				}
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set	
			{
				phoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
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
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public int? StorageMaxDays
		{
			get
			{
				return storageMaxDays;
			}
			set	
			{
				storageMaxDays = value;
				DictionaryUtil.Add(QueryParameters, "StorageMaxDays", value.ToString());
			}
		}

		public List<string> AdminRamIds
		{
			get
			{
				return adminRamIds;
			}

			set
			{
				adminRamIds = value;
				for (int i = 0; i < adminRamIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AdminRamId." + (i + 1) , adminRamIds[i]);
				}
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public int? StorageMaxSize
		{
			get
			{
				return storageMaxSize;
			}
			set	
			{
				storageMaxSize = value;
				DictionaryUtil.Add(QueryParameters, "StorageMaxSize", value.ToString());
			}
		}

		public string DirectoryId
		{
			get
			{
				return directoryId;
			}
			set	
			{
				directoryId = value;
				DictionaryUtil.Add(QueryParameters, "DirectoryId", value);
			}
		}

        public override CreateInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
