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
using Aliyun.Acs.idrsservice.Transform;
using Aliyun.Acs.idrsservice.Transform.V20200630;

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
    public class ListDetectionsRequest : RpcAcsRequest<ListDetectionsResponse>
    {
        public ListDetectionsRequest()
            : base("idrsservice", "2020-06-30", "ListDetections", "idrsservice", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string createDateTo;

		private string departmentId;

		private string recordingType;

		private string createDateFrom;

		private int? pageSize;

		private int? pageIndex;

		private string ruleId;

		public string CreateDateTo
		{
			get
			{
				return createDateTo;
			}
			set	
			{
				createDateTo = value;
				DictionaryUtil.Add(QueryParameters, "CreateDateTo", value);
			}
		}

		public string DepartmentId
		{
			get
			{
				return departmentId;
			}
			set	
			{
				departmentId = value;
				DictionaryUtil.Add(QueryParameters, "DepartmentId", value);
			}
		}

		public string RecordingType
		{
			get
			{
				return recordingType;
			}
			set	
			{
				recordingType = value;
				DictionaryUtil.Add(QueryParameters, "RecordingType", value);
			}
		}

		public string CreateDateFrom
		{
			get
			{
				return createDateFrom;
			}
			set	
			{
				createDateFrom = value;
				DictionaryUtil.Add(QueryParameters, "CreateDateFrom", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "PageIndex", value.ToString());
			}
		}

		public string RuleId
		{
			get
			{
				return ruleId;
			}
			set	
			{
				ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDetectionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDetectionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
