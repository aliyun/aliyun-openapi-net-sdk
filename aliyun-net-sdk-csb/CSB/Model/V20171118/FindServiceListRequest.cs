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
using Aliyun.Acs.CSB.Transform;
using Aliyun.Acs.CSB.Transform.V20171118;
using System.Collections.Generic;

namespace Aliyun.Acs.CSB.Model.V20171118
{
    public class FindServiceListRequest : RpcAcsRequest<FindServiceListResponse>
    {
        public FindServiceListRequest()
            : base("CSB", "2017-11-18", "FindServiceList")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string projectName;

		private bool? showDelService;

		private int? casShowType;

		private long? csbId;

		private string alias;

		private string serviceName;

		private int? pageNum;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(QueryParameters, "ProjectName", value);
			}
		}

		public bool? ShowDelService
		{
			get
			{
				return showDelService;
			}
			set	
			{
				showDelService = value;
				DictionaryUtil.Add(QueryParameters, "ShowDelService", value.ToString());
			}
		}

		public int? CasShowType
		{
			get
			{
				return casShowType;
			}
			set	
			{
				casShowType = value;
				DictionaryUtil.Add(QueryParameters, "CasShowType", value.ToString());
			}
		}

		public long? CsbId
		{
			get
			{
				return csbId;
			}
			set	
			{
				csbId = value;
				DictionaryUtil.Add(QueryParameters, "CsbId", value.ToString());
			}
		}

		public string Alias
		{
			get
			{
				return alias;
			}
			set	
			{
				alias = value;
				DictionaryUtil.Add(QueryParameters, "Alias", value);
			}
		}

		public string ServiceName
		{
			get
			{
				return serviceName;
			}
			set	
			{
				serviceName = value;
				DictionaryUtil.Add(QueryParameters, "ServiceName", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FindServiceListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return FindServiceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}