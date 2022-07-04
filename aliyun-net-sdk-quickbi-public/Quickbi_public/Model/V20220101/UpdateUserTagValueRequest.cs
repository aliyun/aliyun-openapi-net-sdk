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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class UpdateUserTagValueRequest : RpcAcsRequest<UpdateUserTagValueResponse>
    {
        public UpdateUserTagValueRequest()
            : base("quickbi-public", "2022-01-01", "UpdateUserTagValue", "quick", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string tagValue;

		private string tagId;

		private string userId;

		public string TagValue
		{
			get
			{
				return tagValue;
			}
			set	
			{
				tagValue = value;
				DictionaryUtil.Add(QueryParameters, "TagValue", value);
			}
		}

		public string TagId
		{
			get
			{
				return tagId;
			}
			set	
			{
				tagId = value;
				DictionaryUtil.Add(QueryParameters, "TagId", value);
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
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateUserTagValueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserTagValueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
