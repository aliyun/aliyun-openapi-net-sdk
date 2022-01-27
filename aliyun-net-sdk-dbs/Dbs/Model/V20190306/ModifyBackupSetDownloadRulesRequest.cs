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
    public class ModifyBackupSetDownloadRulesRequest : RpcAcsRequest<ModifyBackupSetDownloadRulesResponse>
    {
        public ModifyBackupSetDownloadRulesRequest()
            : base("Dbs", "2019-03-06", "ModifyBackupSetDownloadRules", "cbs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dbs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fullDataFormat;

		private long? backupGatewayId;

		private string clientToken;

		private string backupSetDownloadTargetType;

		private string backupPlanId;

		private string ownerId;

		private bool? openAutoDownload;

		private string incrementDataFormat;

		private string backupSetDownloadTargetTypeLocation;

		private string backupSetDownloadDir;

		public string FullDataFormat
		{
			get
			{
				return fullDataFormat;
			}
			set	
			{
				fullDataFormat = value;
				DictionaryUtil.Add(QueryParameters, "FullDataFormat", value);
			}
		}

		public long? BackupGatewayId
		{
			get
			{
				return backupGatewayId;
			}
			set	
			{
				backupGatewayId = value;
				DictionaryUtil.Add(QueryParameters, "BackupGatewayId", value.ToString());
			}
		}

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

		public string BackupSetDownloadTargetType
		{
			get
			{
				return backupSetDownloadTargetType;
			}
			set	
			{
				backupSetDownloadTargetType = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetDownloadTargetType", value);
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

		public bool? OpenAutoDownload
		{
			get
			{
				return openAutoDownload;
			}
			set	
			{
				openAutoDownload = value;
				DictionaryUtil.Add(QueryParameters, "OpenAutoDownload", value.ToString());
			}
		}

		public string IncrementDataFormat
		{
			get
			{
				return incrementDataFormat;
			}
			set	
			{
				incrementDataFormat = value;
				DictionaryUtil.Add(QueryParameters, "IncrementDataFormat", value);
			}
		}

		public string BackupSetDownloadTargetTypeLocation
		{
			get
			{
				return backupSetDownloadTargetTypeLocation;
			}
			set	
			{
				backupSetDownloadTargetTypeLocation = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetDownloadTargetTypeLocation", value);
			}
		}

		public string BackupSetDownloadDir
		{
			get
			{
				return backupSetDownloadDir;
			}
			set	
			{
				backupSetDownloadDir = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetDownloadDir", value);
			}
		}

        public override ModifyBackupSetDownloadRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyBackupSetDownloadRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
