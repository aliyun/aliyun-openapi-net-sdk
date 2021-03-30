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
using Aliyun.Acs.Dbs.Transform;
using Aliyun.Acs.Dbs.Transform.V20190306;

namespace Aliyun.Acs.Dbs.Model.V20190306
{
    public class DescribeFullBackupSetRequest : RpcAcsRequest<DescribeFullBackupSetResponse>
    {
        public DescribeFullBackupSetRequest()
            : base("Dbs", "2019-03-06", "DescribeFullBackupSet", "cbs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string backupPlanId;

		private string backupsetId;

		private string ownerId;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string BackupPlanId
		{
			get
			{
				return backupPlanId;
			}
			set	
			{
				backupPlanId = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanId", value);
			}
		}

		public string BackupsetId
		{
			get
			{
				return backupsetId;
			}
			set	
			{
				backupsetId = value;
				DictionaryUtil.Add(QueryParameters, "BackupsetId", value);
			}
		}

		public string OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value);
			}
		}

        public override DescribeFullBackupSetResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeFullBackupSetResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
