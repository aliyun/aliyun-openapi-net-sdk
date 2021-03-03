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
using Aliyun.Acs.dataworks_public.Transform.V20180601;

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
    public class CreateRealTimeProcessRequest : RpcAcsRequest<CreateRealTimeProcessResponse>
    {
        public CreateRealTimeProcessRequest()
            : base("dataworks-public", "2018-06-01", "CreateRealTimeProcess")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string jobConfig;

		private bool? createResGroup;

		private string dataworksVersion;

		private string resourceSpec;

		private string tableRule;

		private string tables;

		private string dataSource;

		public string JobConfig
		{
			get
			{
				return jobConfig;
			}
			set	
			{
				jobConfig = value;
				DictionaryUtil.Add(QueryParameters, "JobConfig", value);
			}
		}

		public bool? CreateResGroup
		{
			get
			{
				return createResGroup;
			}
			set	
			{
				createResGroup = value;
				DictionaryUtil.Add(QueryParameters, "CreateResGroup", value.ToString());
			}
		}

		public string DataworksVersion
		{
			get
			{
				return dataworksVersion;
			}
			set	
			{
				dataworksVersion = value;
				DictionaryUtil.Add(QueryParameters, "DataworksVersion", value);
			}
		}

		public string ResourceSpec
		{
			get
			{
				return resourceSpec;
			}
			set	
			{
				resourceSpec = value;
				DictionaryUtil.Add(QueryParameters, "ResourceSpec", value);
			}
		}

		public string TableRule
		{
			get
			{
				return tableRule;
			}
			set	
			{
				tableRule = value;
				DictionaryUtil.Add(QueryParameters, "TableRule", value);
			}
		}

		public string Tables
		{
			get
			{
				return tables;
			}
			set	
			{
				tables = value;
				DictionaryUtil.Add(QueryParameters, "Tables", value);
			}
		}

		public string DataSource
		{
			get
			{
				return dataSource;
			}
			set	
			{
				dataSource = value;
				DictionaryUtil.Add(QueryParameters, "DataSource", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateRealTimeProcessResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRealTimeProcessResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
