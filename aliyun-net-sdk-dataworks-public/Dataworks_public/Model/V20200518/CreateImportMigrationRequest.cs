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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class CreateImportMigrationRequest : RpcAcsRequest<CreateImportMigrationResponse>
    {
        public CreateImportMigrationRequest()
            : base("dataworks-public", "2020-05-18", "CreateImportMigration")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string commitRule;

		private string workspaceMap;

		private string calculateEngineMap;

		private string packageFile;

		private string name;

		private string packageType;

		private long? projectId;

		private string resourceGroupMap;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string CommitRule
		{
			get
			{
				return commitRule;
			}
			set	
			{
				commitRule = value;
				DictionaryUtil.Add(BodyParameters, "CommitRule", value);
			}
		}

		public string WorkspaceMap
		{
			get
			{
				return workspaceMap;
			}
			set	
			{
				workspaceMap = value;
				DictionaryUtil.Add(BodyParameters, "WorkspaceMap", value);
			}
		}

		public string CalculateEngineMap
		{
			get
			{
				return calculateEngineMap;
			}
			set	
			{
				calculateEngineMap = value;
				DictionaryUtil.Add(BodyParameters, "CalculateEngineMap", value);
			}
		}

		public string PackageFile
		{
			get
			{
				return packageFile;
			}
			set	
			{
				packageFile = value;
				DictionaryUtil.Add(BodyParameters, "PackageFile", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string PackageType
		{
			get
			{
				return packageType;
			}
			set	
			{
				packageType = value;
				DictionaryUtil.Add(BodyParameters, "PackageType", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public string ResourceGroupMap
		{
			get
			{
				return resourceGroupMap;
			}
			set	
			{
				resourceGroupMap = value;
				DictionaryUtil.Add(BodyParameters, "ResourceGroupMap", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateImportMigrationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateImportMigrationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
