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
using Aliyun.Acs.jarvis.Transform;
using Aliyun.Acs.jarvis.Transform.V20180206;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
    public class DeleteCdnIpRequest : RpcAcsRequest<DeleteCdnIpResponse>
    {
        public DeleteCdnIpRequest()
            : base("jarvis", "2018-02-06", "DeleteCdnIp", "jarvis", "openAPI")
        {
        }

		private int? itemId;

		private long? resourceOwnerId;

		private string sourceIp;

		private string cdnIp;

		private string lang;

		private string sourceCode;

		public int? ItemId
		{
			get
			{
				return itemId;
			}
			set	
			{
				itemId = value;
				DictionaryUtil.Add(QueryParameters, "ItemId", value.ToString());
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

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string CdnIp
		{
			get
			{
				return cdnIp;
			}
			set	
			{
				cdnIp = value;
				DictionaryUtil.Add(QueryParameters, "CdnIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string SourceCode
		{
			get
			{
				return sourceCode;
			}
			set	
			{
				sourceCode = value;
				DictionaryUtil.Add(QueryParameters, "SourceCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteCdnIpResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteCdnIpResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
