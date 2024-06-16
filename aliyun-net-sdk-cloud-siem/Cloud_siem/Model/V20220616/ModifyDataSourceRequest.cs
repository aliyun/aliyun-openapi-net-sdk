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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class ModifyDataSourceRequest : RpcAcsRequest<ModifyDataSourceResponse>
    {
        public ModifyDataSourceRequest()
            : base("cloud-siem", "2022-06-16", "ModifyDataSource", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string dataSourceType;

		private string cloudCode;

		private string dataSourceInstanceName;

		private string accountId;

		private string dataSourceInstanceRemark;

		private string dataSourceInstanceParams;

		private string dataSourceInstanceId;

		public string DataSourceType
		{
			get
			{
				return dataSourceType;
			}
			set	
			{
				dataSourceType = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceType", value);
			}
		}

		public string CloudCode
		{
			get
			{
				return cloudCode;
			}
			set	
			{
				cloudCode = value;
				DictionaryUtil.Add(BodyParameters, "CloudCode", value);
			}
		}

		public string DataSourceInstanceName
		{
			get
			{
				return dataSourceInstanceName;
			}
			set	
			{
				dataSourceInstanceName = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceInstanceName", value);
			}
		}

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(BodyParameters, "AccountId", value);
			}
		}

		public string DataSourceInstanceRemark
		{
			get
			{
				return dataSourceInstanceRemark;
			}
			set	
			{
				dataSourceInstanceRemark = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceInstanceRemark", value);
			}
		}

		public string DataSourceInstanceParams
		{
			get
			{
				return dataSourceInstanceParams;
			}
			set	
			{
				dataSourceInstanceParams = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceInstanceParams", value);
			}
		}

		public string DataSourceInstanceId
		{
			get
			{
				return dataSourceInstanceId;
			}
			set	
			{
				dataSourceInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "DataSourceInstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyDataSourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDataSourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
