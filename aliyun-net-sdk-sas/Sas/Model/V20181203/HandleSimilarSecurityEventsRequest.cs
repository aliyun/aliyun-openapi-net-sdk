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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class HandleSimilarSecurityEventsRequest : RpcAcsRequest<HandleSimilarSecurityEventsResponse>
    {
        public HandleSimilarSecurityEventsRequest()
            : base("Sas", "2018-12-03", "HandleSimilarSecurityEvents", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string markMissParam;

		private long? resourceOwnerId;

		private string sourceIp;

		private string operationCode;

		private long? taskId;

		private string operationParams;

		public string MarkMissParam
		{
			get
			{
				return markMissParam;
			}
			set	
			{
				markMissParam = value;
				DictionaryUtil.Add(QueryParameters, "MarkMissParam", value);
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

		public string OperationCode
		{
			get
			{
				return operationCode;
			}
			set	
			{
				operationCode = value;
				DictionaryUtil.Add(QueryParameters, "OperationCode", value);
			}
		}

		public long? TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value.ToString());
			}
		}

		public string OperationParams
		{
			get
			{
				return operationParams;
			}
			set	
			{
				operationParams = value;
				DictionaryUtil.Add(QueryParameters, "OperationParams", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override HandleSimilarSecurityEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return HandleSimilarSecurityEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
