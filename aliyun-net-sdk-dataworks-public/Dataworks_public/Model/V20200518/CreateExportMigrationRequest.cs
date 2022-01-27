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
    public class CreateExportMigrationRequest : RpcAcsRequest<CreateExportMigrationResponse>
    {
        public CreateExportMigrationRequest()
            : base("dataworks-public", "2020-05-18", "CreateExportMigration")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string exportObjectStatus;

		private string exportMode;

		private long? incrementalSince;

		private string name;

		private string description;

		private long? projectId;

		public string ExportObjectStatus
		{
			get
			{
				return exportObjectStatus;
			}
			set	
			{
				exportObjectStatus = value;
				DictionaryUtil.Add(BodyParameters, "ExportObjectStatus", value);
			}
		}

		public string ExportMode
		{
			get
			{
				return exportMode;
			}
			set	
			{
				exportMode = value;
				DictionaryUtil.Add(BodyParameters, "ExportMode", value);
			}
		}

		public long? IncrementalSince
		{
			get
			{
				return incrementalSince;
			}
			set	
			{
				incrementalSince = value;
				DictionaryUtil.Add(BodyParameters, "IncrementalSince", value.ToString());
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateExportMigrationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateExportMigrationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
