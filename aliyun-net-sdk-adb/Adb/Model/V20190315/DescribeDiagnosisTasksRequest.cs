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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20190315;

namespace Aliyun.Acs.adb.Model.V20190315
{
    public class DescribeDiagnosisTasksRequest : RpcAcsRequest<DescribeDiagnosisTasksResponse>
    {
        public DescribeDiagnosisTasksRequest()
            : base("adb", "2019-03-15", "DescribeDiagnosisTasks", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
        }

		private string dBClusterId;

		private int? pageNumber;

		private string processId;

		private int? pageSize;

		private string host;

		private string state;

		private string stageId;

		private string order;

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string ProcessId
		{
			get
			{
				return processId;
			}
			set	
			{
				processId = value;
				DictionaryUtil.Add(QueryParameters, "ProcessId", value);
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

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
				DictionaryUtil.Add(QueryParameters, "Host", value);
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "State", value);
			}
		}

		public string StageId
		{
			get
			{
				return stageId;
			}
			set	
			{
				stageId = value;
				DictionaryUtil.Add(QueryParameters, "StageId", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDiagnosisTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDiagnosisTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
