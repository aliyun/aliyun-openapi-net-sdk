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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class CreateOrUpdateDataSourceRequest : RpcAcsRequest<CreateOrUpdateDataSourceResponse>
    {
        public CreateOrUpdateDataSourceRequest()
            : base("aegis", "2016-11-11", "CreateOrUpdateDataSource", "vipaegis", "openAPI")
        {
        }

		private string projectName;

		private string sourceIp;

		private string logStoreName;

		private string datasourceDescription;

		private string fields;

		private string regionNo;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(QueryParameters, "ProjectName", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public string LogStoreName
		{
			get
			{
				return logStoreName;
			}
			set	
			{
				logStoreName = value;
				DictionaryUtil.Add(QueryParameters, "LogStoreName", value);
			}
		}

		public string DatasourceDescription
		{
			get
			{
				return datasourceDescription;
			}
			set	
			{
				datasourceDescription = value;
				DictionaryUtil.Add(QueryParameters, "DatasourceDescription", value);
			}
		}

		public string Fields
		{
			get
			{
				return fields;
			}
			set	
			{
				fields = value;
				DictionaryUtil.Add(QueryParameters, "Fields", value);
			}
		}

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "RegionNo", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateOrUpdateDataSourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrUpdateDataSourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
