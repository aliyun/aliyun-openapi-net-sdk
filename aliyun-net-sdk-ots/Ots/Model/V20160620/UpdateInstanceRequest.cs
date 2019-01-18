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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ots.Transform;
using Aliyun.Acs.Ots.Transform.V20160620;
using System.Collections.Generic;

namespace Aliyun.Acs.Ots.Model.V20160620
{
    public class UpdateInstanceRequest : RpcAcsRequest<UpdateInstanceResponse>
    {
        public UpdateInstanceRequest()
            : base("Ots", "2016-06-20", "UpdateInstance", "ots", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string access_key_id;

		private long? resourceOwnerId;

		private string instanceName;

		private string action;

		private string network;

		public string Access_key_id
		{
			get
			{
				return access_key_id;
			}
			set	
			{
				access_key_id = value;
				DictionaryUtil.Add(QueryParameters, "access_key_id", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
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
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string Network
		{
			get
			{
				return network;
			}
			set	
			{
				network = value;
				DictionaryUtil.Add(QueryParameters, "Network", value);
			}
		}

        public override UpdateInstanceResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}