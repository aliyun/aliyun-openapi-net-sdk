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
    public class CreateStatisticsTaskRequest : RpcAcsRequest<CreateStatisticsTaskResponse>
    {
        public CreateStatisticsTaskRequest()
            : base("idrsservice", "2020-06-30", "CreateStatisticsTask", "idrsservice", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private List<string> departmentIds = new List<string>(){ };

		private string dateTo;

		private string dateFrom;

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

		public List<string> DepartmentIds
		{
			get
			{
				return departmentIds;
			}

			set
			{
				departmentIds = value;
				for (int i = 0; i < departmentIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DepartmentId." + (i + 1) , departmentIds[i]);
				}
			}
		}

		public string DateTo
		{
			get
			{
				return dateTo;
			}
			set	
			{
				dateTo = value;
				DictionaryUtil.Add(QueryParameters, "DateTo", value);
			}
		}

		public string DateFrom
		{
			get
			{
				return dateFrom;
			}
			set	
			{
				dateFrom = value;
				DictionaryUtil.Add(QueryParameters, "DateFrom", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateStatisticsTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateStatisticsTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
