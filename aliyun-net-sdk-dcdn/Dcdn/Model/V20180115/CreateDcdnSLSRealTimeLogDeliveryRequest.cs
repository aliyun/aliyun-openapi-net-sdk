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
using Aliyun.Acs.dcdn;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class CreateDcdnSLSRealTimeLogDeliveryRequest : RpcAcsRequest<CreateDcdnSLSRealTimeLogDeliveryResponse>
    {
        public CreateDcdnSLSRealTimeLogDeliveryRequest()
            : base("dcdn", "2018-01-15", "CreateDcdnSLSRealTimeLogDelivery")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sLSLogStore;

		private string sLSProject;

		private string businessType;

		private string sLSRegion;

		private string projectName;

		private string domainName;

		private string samplingRate;

		private string dataCenter;

		private long? ownerId;

		public string SLSLogStore
		{
			get
			{
				return sLSLogStore;
			}
			set	
			{
				sLSLogStore = value;
				DictionaryUtil.Add(BodyParameters, "SLSLogStore", value);
			}
		}

		public string SLSProject
		{
			get
			{
				return sLSProject;
			}
			set	
			{
				sLSProject = value;
				DictionaryUtil.Add(BodyParameters, "SLSProject", value);
			}
		}

		public string BusinessType
		{
			get
			{
				return businessType;
			}
			set	
			{
				businessType = value;
				DictionaryUtil.Add(BodyParameters, "BusinessType", value);
			}
		}

		public string SLSRegion
		{
			get
			{
				return sLSRegion;
			}
			set	
			{
				sLSRegion = value;
				DictionaryUtil.Add(BodyParameters, "SLSRegion", value);
			}
		}

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(BodyParameters, "ProjectName", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(BodyParameters, "DomainName", value);
			}
		}

		public string SamplingRate
		{
			get
			{
				return samplingRate;
			}
			set	
			{
				samplingRate = value;
				DictionaryUtil.Add(BodyParameters, "SamplingRate", value);
			}
		}

		public string DataCenter
		{
			get
			{
				return dataCenter;
			}
			set	
			{
				dataCenter = value;
				DictionaryUtil.Add(BodyParameters, "DataCenter", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override CreateDcdnSLSRealTimeLogDeliveryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDcdnSLSRealTimeLogDeliveryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
