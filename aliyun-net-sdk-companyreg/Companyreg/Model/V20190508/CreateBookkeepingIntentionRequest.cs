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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class CreateBookkeepingIntentionRequest : RpcAcsRequest<CreateBookkeepingIntentionResponse>
    {
        public CreateBookkeepingIntentionRequest()
            : base("companyreg", "2019-05-08", "CreateBookkeepingIntention", "companyreg", "openAPI")
        {
        }

		private string area;

		private string mobile;

		private string description;

		private string verifyCode;

		private string userName;

		public string Area
		{
			get
			{
				return area;
			}
			set	
			{
				area = value;
				DictionaryUtil.Add(QueryParameters, "Area", value);
			}
		}

		public string Mobile
		{
			get
			{
				return mobile;
			}
			set	
			{
				mobile = value;
				DictionaryUtil.Add(QueryParameters, "Mobile", value);
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

		public string VerifyCode
		{
			get
			{
				return verifyCode;
			}
			set	
			{
				verifyCode = value;
				DictionaryUtil.Add(QueryParameters, "VerifyCode", value);
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateBookkeepingIntentionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateBookkeepingIntentionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
