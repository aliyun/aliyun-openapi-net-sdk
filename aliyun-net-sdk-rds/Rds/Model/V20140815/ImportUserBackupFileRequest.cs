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
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ImportUserBackupFileRequest : RpcAcsRequest<ImportUserBackupFileResponse>
    {
        public ImportUserBackupFileRequest()
            : base("Rds", "2014-08-15", "ImportUserBackupFile", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string engineVersion;

		private int? retention;

		private string resourceOwnerAccount;

		private string backupFile;

		private string bucketRegion;

		private long? ownerId;

		private int? restoreSize;

		private string zoneId;

		private string comment;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string EngineVersion
		{
			get
			{
				return engineVersion;
			}
			set	
			{
				engineVersion = value;
				DictionaryUtil.Add(QueryParameters, "EngineVersion", value);
			}
		}

		public int? Retention
		{
			get
			{
				return retention;
			}
			set	
			{
				retention = value;
				DictionaryUtil.Add(QueryParameters, "Retention", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string BackupFile
		{
			get
			{
				return backupFile;
			}
			set	
			{
				backupFile = value;
				DictionaryUtil.Add(QueryParameters, "BackupFile", value);
			}
		}

		public string BucketRegion
		{
			get
			{
				return bucketRegion;
			}
			set	
			{
				bucketRegion = value;
				DictionaryUtil.Add(QueryParameters, "BucketRegion", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? RestoreSize
		{
			get
			{
				return restoreSize;
			}
			set	
			{
				restoreSize = value;
				DictionaryUtil.Add(QueryParameters, "RestoreSize", value.ToString());
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ImportUserBackupFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportUserBackupFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
