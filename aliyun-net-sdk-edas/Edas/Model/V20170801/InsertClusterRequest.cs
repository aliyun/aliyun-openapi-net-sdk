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
using Aliyun.Acs.Edas.Transform;
using Aliyun.Acs.Edas.Transform.V20170801;

namespace Aliyun.Acs.Edas.Model.V20170801
{
    public class InsertClusterRequest : RoaAcsRequest<InsertClusterResponse>
    {
        public InsertClusterRequest()
            : base("Edas", "2017-08-01", "InsertCluster", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/resource/cluster";
			Method = MethodType.POST;
        }

		private int? clusterType;

		private string iaasProvider;

		private string logicalRegionId;

		private string clusterName;

		private string vpcId;

		private int? networkMode;

		private int? oversoldFactor;

		public int? ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
				DictionaryUtil.Add(QueryParameters, "ClusterType", value.ToString());
			}
		}

		public string IaasProvider
		{
			get
			{
				return iaasProvider;
			}
			set	
			{
				iaasProvider = value;
				DictionaryUtil.Add(QueryParameters, "IaasProvider", value);
			}
		}

		public string LogicalRegionId
		{
			get
			{
				return logicalRegionId;
			}
			set	
			{
				logicalRegionId = value;
				DictionaryUtil.Add(QueryParameters, "LogicalRegionId", value);
			}
		}

		public string ClusterName
		{
			get
			{
				return clusterName;
			}
			set	
			{
				clusterName = value;
				DictionaryUtil.Add(QueryParameters, "ClusterName", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public int? NetworkMode
		{
			get
			{
				return networkMode;
			}
			set	
			{
				networkMode = value;
				DictionaryUtil.Add(QueryParameters, "NetworkMode", value.ToString());
			}
		}

		public int? OversoldFactor
		{
			get
			{
				return oversoldFactor;
			}
			set	
			{
				oversoldFactor = value;
				DictionaryUtil.Add(QueryParameters, "OversoldFactor", value.ToString());
			}
		}

        public override InsertClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return InsertClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
