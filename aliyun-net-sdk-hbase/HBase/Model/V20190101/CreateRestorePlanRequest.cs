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
    public class CreateRestorePlanRequest : RpcAcsRequest<CreateRestorePlanResponse>
    {
        public CreateRestorePlanRequest()
            : base("HBase", "2019-01-01", "CreateRestorePlan", "hbase", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.HBase.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string restoreToDate;

		private string tables;

		private bool? restoreByCopy;

		private bool? restoreAllTable;

		private string clusterId;

		private string targetClusterId;

		public string RestoreToDate
		{
			get
			{
				return restoreToDate;
			}
			set	
			{
				restoreToDate = value;
				DictionaryUtil.Add(QueryParameters, "RestoreToDate", value);
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

		public bool? RestoreByCopy
		{
			get
			{
				return restoreByCopy;
			}
			set	
			{
				restoreByCopy = value;
				DictionaryUtil.Add(QueryParameters, "RestoreByCopy", value.ToString());
			}
		}

		public bool? RestoreAllTable
		{
			get
			{
				return restoreAllTable;
			}
			set	
			{
				restoreAllTable = value;
				DictionaryUtil.Add(QueryParameters, "RestoreAllTable", value.ToString());
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

		public string TargetClusterId
		{
			get
			{
				return targetClusterId;
			}
			set	
			{
				targetClusterId = value;
				DictionaryUtil.Add(QueryParameters, "TargetClusterId", value);
			}
		}

        public override CreateRestorePlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRestorePlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
