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
using Aliyun.Acs.Dts.Transform;
using Aliyun.Acs.Dts.Transform.V20200101;

namespace Aliyun.Acs.Dts.Model.V20200101
{
    public class CreateDtsInstanceRequest : RpcAcsRequest<CreateDtsInstanceResponse>
    {
        public CreateDtsInstanceRequest()
            : base("Dts", "2020-01-01", "CreateDtsInstance", "dts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dts.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? autoStart;

		private string type;

		private string instanceClass;

		private int? databaseCount;

		private string jobId;

		private int? computeUnit;

		private string destinationRegion;

		private string period;

		private string destinationEndpointEngineName;

		private int? quantity;

		private bool? autoPay;

		private int? usedTime;

		private string syncArchitecture;

		private string payType;

		private string sourceRegion;

		private string sourceEndpointEngineName;

		public bool? AutoStart
		{
			get
			{
				return autoStart;
			}
			set	
			{
				autoStart = value;
				DictionaryUtil.Add(QueryParameters, "AutoStart", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string InstanceClass
		{
			get
			{
				return instanceClass;
			}
			set	
			{
				instanceClass = value;
				DictionaryUtil.Add(QueryParameters, "InstanceClass", value);
			}
		}

		public int? DatabaseCount
		{
			get
			{
				return databaseCount;
			}
			set	
			{
				databaseCount = value;
				DictionaryUtil.Add(QueryParameters, "DatabaseCount", value.ToString());
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
			}
		}

		public int? ComputeUnit
		{
			get
			{
				return computeUnit;
			}
			set	
			{
				computeUnit = value;
				DictionaryUtil.Add(QueryParameters, "ComputeUnit", value.ToString());
			}
		}

		public string DestinationRegion
		{
			get
			{
				return destinationRegion;
			}
			set	
			{
				destinationRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestinationRegion", value);
			}
		}

		public string Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value);
			}
		}

		public string DestinationEndpointEngineName
		{
			get
			{
				return destinationEndpointEngineName;
			}
			set	
			{
				destinationEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "DestinationEndpointEngineName", value);
			}
		}

		public int? Quantity
		{
			get
			{
				return quantity;
			}
			set	
			{
				quantity = value;
				DictionaryUtil.Add(QueryParameters, "Quantity", value.ToString());
			}
		}

		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		public int? UsedTime
		{
			get
			{
				return usedTime;
			}
			set	
			{
				usedTime = value;
				DictionaryUtil.Add(QueryParameters, "UsedTime", value.ToString());
			}
		}

		public string SyncArchitecture
		{
			get
			{
				return syncArchitecture;
			}
			set	
			{
				syncArchitecture = value;
				DictionaryUtil.Add(QueryParameters, "SyncArchitecture", value);
			}
		}

		public string PayType
		{
			get
			{
				return payType;
			}
			set	
			{
				payType = value;
				DictionaryUtil.Add(QueryParameters, "PayType", value);
			}
		}

		public string SourceRegion
		{
			get
			{
				return sourceRegion;
			}
			set	
			{
				sourceRegion = value;
				DictionaryUtil.Add(QueryParameters, "SourceRegion", value);
			}
		}

		public string SourceEndpointEngineName
		{
			get
			{
				return sourceEndpointEngineName;
			}
			set	
			{
				sourceEndpointEngineName = value;
				DictionaryUtil.Add(QueryParameters, "SourceEndpointEngineName", value);
			}
		}

        public override CreateDtsInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDtsInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
