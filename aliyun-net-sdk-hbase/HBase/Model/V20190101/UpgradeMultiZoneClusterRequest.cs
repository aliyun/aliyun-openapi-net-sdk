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
using Aliyun.Acs.HBase.Transform;
using Aliyun.Acs.HBase.Transform.V20190101;

namespace Aliyun.Acs.HBase.Model.V20190101
{
    public class UpgradeMultiZoneClusterRequest : RpcAcsRequest<UpgradeMultiZoneClusterResponse>
    {
        public UpgradeMultiZoneClusterRequest()
            : base("HBase", "2019-01-01", "UpgradeMultiZoneCluster", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string runMode;

		private string components;

		private string upgradeInsName;

		private string restartComponents;

		private string clusterId;

		private string versions;

		public string RunMode
		{
			get
			{
				return runMode;
			}
			set	
			{
				runMode = value;
				DictionaryUtil.Add(QueryParameters, "RunMode", value);
			}
		}

		public string Components
		{
			get
			{
				return components;
			}
			set	
			{
				components = value;
				DictionaryUtil.Add(QueryParameters, "Components", value);
			}
		}

		public string UpgradeInsName
		{
			get
			{
				return upgradeInsName;
			}
			set	
			{
				upgradeInsName = value;
				DictionaryUtil.Add(QueryParameters, "UpgradeInsName", value);
			}
		}

		public string RestartComponents
		{
			get
			{
				return restartComponents;
			}
			set	
			{
				restartComponents = value;
				DictionaryUtil.Add(QueryParameters, "RestartComponents", value);
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string Versions
		{
			get
			{
				return versions;
			}
			set	
			{
				versions = value;
				DictionaryUtil.Add(QueryParameters, "Versions", value);
			}
		}

        public override UpgradeMultiZoneClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpgradeMultiZoneClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
