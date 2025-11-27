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
using Aliyun.Acs.polardb.Transform;
using Aliyun.Acs.polardb.Transform.V20170801;

namespace Aliyun.Acs.polardb.Model.V20170801
{
    public class ModifyDBClusterArchRequest : RpcAcsRequest<ModifyDBClusterArchResponse>
    {
        public ModifyDBClusterArchRequest()
            : base("polardb", "2017-08-01", "ModifyDBClusterArch", "polardb", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardb.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string standbyAZ;

		private string dBClusterId;

		private string hotStandbyCluster;

		public string StandbyAZ
		{
			get
			{
				return standbyAZ;
			}
			set	
			{
				standbyAZ = value;
				DictionaryUtil.Add(QueryParameters, "StandbyAZ", value);
			}
		}

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

		public string HotStandbyCluster
		{
			get
			{
				return hotStandbyCluster;
			}
			set	
			{
				hotStandbyCluster = value;
				DictionaryUtil.Add(QueryParameters, "HotStandbyCluster", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDBClusterArchResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDBClusterArchResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
