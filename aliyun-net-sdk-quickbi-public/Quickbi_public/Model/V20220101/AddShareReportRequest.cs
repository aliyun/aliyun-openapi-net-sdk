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
    public class AddShareReportRequest : RpcAcsRequest<AddShareReportResponse>
    {
        public AddShareReportRequest()
            : base("quickbi-public", "2022-01-01", "AddShareReport", "quick", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? authPoint;

		private long? expireDate;

		private int? shareToType;

		private string worksId;

		private string shareToId;

		public int? AuthPoint
		{
			get
			{
				return authPoint;
			}
			set	
			{
				authPoint = value;
				DictionaryUtil.Add(QueryParameters, "AuthPoint", value.ToString());
			}
		}

		public long? ExpireDate
		{
			get
			{
				return expireDate;
			}
			set	
			{
				expireDate = value;
				DictionaryUtil.Add(QueryParameters, "ExpireDate", value.ToString());
			}
		}

		public int? ShareToType
		{
			get
			{
				return shareToType;
			}
			set	
			{
				shareToType = value;
				DictionaryUtil.Add(QueryParameters, "ShareToType", value.ToString());
			}
		}

		public string WorksId
		{
			get
			{
				return worksId;
			}
			set	
			{
				worksId = value;
				DictionaryUtil.Add(QueryParameters, "WorksId", value);
			}
		}

		public string ShareToId
		{
			get
			{
				return shareToId;
			}
			set	
			{
				shareToId = value;
				DictionaryUtil.Add(QueryParameters, "ShareToId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddShareReportResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddShareReportResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
