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
    public class SetUserBusinessStatusRequest : RpcAcsRequest<SetUserBusinessStatusResponse>
    {
        public SetUserBusinessStatusRequest()
            : base("Ubsms", "2015-06-23", "SetUserBusinessStatus", "ubsms", "openAPI")
        {
        }

		private string uid;

		private string statusValue;

		private string service;

		private string statusKey;

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

		public string StatusValue
		{
			get
			{
				return statusValue;
			}
			set	
			{
				statusValue = value;
				DictionaryUtil.Add(QueryParameters, "StatusValue", value);
			}
		}

		public string Service
		{
			get
			{
				return service;
			}
			set	
			{
				service = value;
				DictionaryUtil.Add(QueryParameters, "Service", value);
			}
		}

		public string StatusKey
		{
			get
			{
				return statusKey;
			}
			set	
			{
				statusKey = value;
				DictionaryUtil.Add(QueryParameters, "StatusKey", value);
			}
		}

        public override SetUserBusinessStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetUserBusinessStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
