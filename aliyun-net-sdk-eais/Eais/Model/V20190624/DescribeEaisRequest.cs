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
using Aliyun.Acs.eais.Transform;
using Aliyun.Acs.eais.Transform.V20190624;

namespace Aliyun.Acs.eais.Model.V20190624
{
    public class DescribeEaisRequest : RpcAcsRequest<DescribeEaisResponse>
    {
        public DescribeEaisRequest()
            : base("eais", "2019-06-24", "DescribeEais", "eais", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.eais.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.eais.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string elasticAcceleratedInstanceIds;

		private string instanceName;

		private string instanceType;

		private string status;

		public string ElasticAcceleratedInstanceIds
		{
			get
			{
				return elasticAcceleratedInstanceIds;
			}
			set	
			{
				elasticAcceleratedInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "ElasticAcceleratedInstanceIds", value);
			}
		}

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override DescribeEaisResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeEaisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
