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
    public class GetGrayAppsRequest : RoaAcsRequest<GetGrayAppsResponse>
    {
        public GetGrayAppsRequest()
            : base("Edas", "2017-08-01", "GetGrayApps", "Edas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Edas.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v5/gray/app_list";
			Method = MethodType.GET;
        }

		private int? clusterTypes;

		private int? appname;

		private string physicalRegionId;

		public int? ClusterTypes
		{
			get
			{
				return clusterTypes;
			}
			set	
			{
				clusterTypes = value;
				DictionaryUtil.Add(QueryParameters, "ClusterTypes", value.ToString());
			}
		}

		public int? Appname
		{
			get
			{
				return appname;
			}
			set	
			{
				appname = value;
				DictionaryUtil.Add(QueryParameters, "Appname", value.ToString());
			}
		}

		public string PhysicalRegionId
		{
			get
			{
				return physicalRegionId;
			}
			set	
			{
				physicalRegionId = value;
				DictionaryUtil.Add(QueryParameters, "PhysicalRegionId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetGrayAppsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetGrayAppsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
