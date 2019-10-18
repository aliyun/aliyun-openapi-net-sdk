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
using Aliyun.Acs.DnsKnocker.Transform;
using Aliyun.Acs.DnsKnocker.Transform.V20190910;

namespace Aliyun.Acs.DnsKnocker.Model.V20190910
{
    public class BatchCreateRrRequest : RpcAcsRequest<BatchCreateRrResponse>
    {
        public BatchCreateRrRequest()
            : base("DnsKnocker", "2019-09-10", "BatchCreateRr", "dns_knocker", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string accessID;

		private string accessSecret;

		private string resourceRecords;

		private string line;

		private string zoneName;

		private string transactionId;

		private string group;

		public string AccessID
		{
			get
			{
				return accessID;
			}
			set	
			{
				accessID = value;
				DictionaryUtil.Add(BodyParameters, "AccessID", value);
			}
		}

		public string AccessSecret
		{
			get
			{
				return accessSecret;
			}
			set	
			{
				accessSecret = value;
				DictionaryUtil.Add(BodyParameters, "AccessSecret", value);
			}
		}

		public string ResourceRecords
		{
			get
			{
				return resourceRecords;
			}
			set	
			{
				resourceRecords = value;
				DictionaryUtil.Add(BodyParameters, "ResourceRecords", value);
			}
		}

		public string Line
		{
			get
			{
				return line;
			}
			set	
			{
				line = value;
				DictionaryUtil.Add(BodyParameters, "Line", value);
			}
		}

		public string ZoneName
		{
			get
			{
				return zoneName;
			}
			set	
			{
				zoneName = value;
				DictionaryUtil.Add(BodyParameters, "ZoneName", value);
			}
		}

		public string TransactionId
		{
			get
			{
				return transactionId;
			}
			set	
			{
				transactionId = value;
				DictionaryUtil.Add(BodyParameters, "TransactionId", value);
			}
		}

		public string Group
		{
			get
			{
				return group;
			}
			set	
			{
				group = value;
				DictionaryUtil.Add(BodyParameters, "Group", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override BatchCreateRrResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchCreateRrResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
