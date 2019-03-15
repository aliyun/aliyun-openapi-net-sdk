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
using Aliyun.Acs.Ubsms.Transform;
using Aliyun.Acs.Ubsms.Transform.V20150623;

namespace Aliyun.Acs.Ubsms.Model.V20150623
{
    public class NotifyUserBusinessCommandRequest : RpcAcsRequest<NotifyUserBusinessCommandResponse>
    {
        public NotifyUserBusinessCommandRequest()
            : base("Ubsms", "2015-06-23", "NotifyUserBusinessCommand", "ubsms", "openAPI")
        {
        }

		private string uid;

		private string password;

		private string instanceId;

		private string serviceCode;

		private string clientToken;

		private string cmd;

		private string region;

		public string Uid
		{
			get
			{
				return uid;
			}
			set	
			{
				uid = value;
				DictionaryUtil.Add(QueryParameters, "Uid", value);
			}
		}

		public string Password
		{
			get
			{
				return password;
			}
			set	
			{
				password = value;
				DictionaryUtil.Add(QueryParameters, "Password", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ServiceCode
		{
			get
			{
				return serviceCode;
			}
			set	
			{
				serviceCode = value;
				DictionaryUtil.Add(QueryParameters, "ServiceCode", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string Cmd
		{
			get
			{
				return cmd;
			}
			set	
			{
				cmd = value;
				DictionaryUtil.Add(QueryParameters, "Cmd", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

        public override NotifyUserBusinessCommandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return NotifyUserBusinessCommandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
