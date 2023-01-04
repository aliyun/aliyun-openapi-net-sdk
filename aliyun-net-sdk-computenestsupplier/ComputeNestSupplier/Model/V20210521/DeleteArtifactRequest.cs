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
    public class DeleteArtifactRequest : RpcAcsRequest<DeleteArtifactResponse>
    {
        public DeleteArtifactRequest()
            : base("ComputeNestSupplier", "2021-05-21", "DeleteArtifact")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string artifactVersion;

		private string artifactId;

		public string ArtifactVersion
		{
			get
			{
				return artifactVersion;
			}
			set	
			{
				artifactVersion = value;
				DictionaryUtil.Add(QueryParameters, "ArtifactVersion", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteArtifactResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteArtifactResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
