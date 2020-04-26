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
using Aliyun.Acs.digitalstore.Transform;
using Aliyun.Acs.digitalstore.Transform.V20200107;

namespace Aliyun.Acs.digitalstore.Model.V20200107
{
    public class ListTakeStockOrderTasksRequest : RpcAcsRequest<ListTakeStockOrderTasksResponse>
    {
        public ListTakeStockOrderTasksRequest()
            : base("digitalstore", "2020-01-07", "ListTakeStockOrderTasks", "digitalstore", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string takeStockTaskId;

		private string orderByField;

		private int? pageNumber;

		private List<string> statusCodes = new List<string>(){ };

		private string deviceNumber;

		private string takeStockOrderId;

		private int? pageSize;

		private string taskCode;

		private string orderByMethod;

		public string TakeStockTaskId
		{
			get
			{
				return takeStockTaskId;
			}
			set	
			{
				takeStockTaskId = value;
				DictionaryUtil.Add(BodyParameters, "TakeStockTaskId", value);
			}
		}

		public string OrderByField
		{
			get
			{
				return orderByField;
			}
			set	
			{
				orderByField = value;
				DictionaryUtil.Add(BodyParameters, "OrderByField", value);
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
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		public List<string> StatusCodes
		{
			get
			{
				return statusCodes;
			}

			set
			{
				statusCodes = value;
				for (int i = 0; i < statusCodes.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"StatusCode." + (i + 1) , statusCodes[i]);
				}
			}
		}

		public string DeviceNumber
		{
			get
			{
				return deviceNumber;
			}
			set	
			{
				deviceNumber = value;
				DictionaryUtil.Add(BodyParameters, "DeviceNumber", value);
			}
		}

		public string TakeStockOrderId
		{
			get
			{
				return takeStockOrderId;
			}
			set	
			{
				takeStockOrderId = value;
				DictionaryUtil.Add(BodyParameters, "TakeStockOrderId", value);
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
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string TaskCode
		{
			get
			{
				return taskCode;
			}
			set	
			{
				taskCode = value;
				DictionaryUtil.Add(BodyParameters, "TaskCode", value);
			}
		}

		public string OrderByMethod
		{
			get
			{
				return orderByMethod;
			}
			set	
			{
				orderByMethod = value;
				DictionaryUtil.Add(BodyParameters, "OrderByMethod", value);
			}
		}

        public override ListTakeStockOrderTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTakeStockOrderTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
