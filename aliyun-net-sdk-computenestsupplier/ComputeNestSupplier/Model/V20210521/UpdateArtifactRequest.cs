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
using Aliyun.Acs.ComputeNestSupplier;
using Aliyun.Acs.ComputeNestSupplier.Transform;
using Aliyun.Acs.ComputeNestSupplier.Transform.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
    public class UpdateArtifactRequest : RpcAcsRequest<UpdateArtifactResponse>
    {
        public UpdateArtifactRequest()
            : base("ComputeNestSupplier", "2021-05-21", "UpdateArtifact")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private List<string> supportRegionIdss = new List<string>(){ };

		private string artifactId;

		private string artifactProperty;

		private string versionName;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public List<string> SupportRegionIdss
		{
			get
			{
				return supportRegionIdss;
			}

			set
			{
				supportRegionIdss = value;
			}
		}

		public string ArtifactId
		{
			get
			{
				return artifactId;
			}
			set	
			{
				artifactId = value;
				DictionaryUtil.Add(QueryParameters, "ArtifactId", value);
			}
		}

		public string ArtifactProperty
		{
			get
			{
				return artifactProperty;
			}
			set	
			{
				artifactProperty = value;
				DictionaryUtil.Add(QueryParameters, "ArtifactProperty", value);
			}
		}

		public string VersionName
		{
			get
			{
				return versionName;
			}
			set	
			{
				versionName = value;
				DictionaryUtil.Add(QueryParameters, "VersionName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateArtifactResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateArtifactResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
