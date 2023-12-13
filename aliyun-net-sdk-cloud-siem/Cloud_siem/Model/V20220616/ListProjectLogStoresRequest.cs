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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class ListProjectLogStoresRequest : RpcAcsRequest<ListProjectLogStoresResponse>
    {
        public ListProjectLogStoresRequest()
            : base("cloud-siem", "2022-06-16", "ListProjectLogStores", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? subUserId;

		private string sourceProdCode;

		private string sourceLogCode;

		public long? SubUserId
		{
			get
			{
				return subUserId;
			}
			set	
			{
				subUserId = value;
				DictionaryUtil.Add(BodyParameters, "SubUserId", value.ToString());
			}
		}

		public string SourceProdCode
		{
			get
			{
				return sourceProdCode;
			}
			set	
			{
				sourceProdCode = value;
				DictionaryUtil.Add(BodyParameters, "SourceProdCode", value);
			}
		}

		public string SourceLogCode
		{
			get
			{
				return sourceLogCode;
			}
			set	
			{
				sourceLogCode = value;
				DictionaryUtil.Add(BodyParameters, "SourceLogCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListProjectLogStoresResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListProjectLogStoresResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
