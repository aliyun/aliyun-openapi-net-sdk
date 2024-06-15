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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class UpdateBackupPolicyRequest : RpcAcsRequest<UpdateBackupPolicyResponse>
    {
        public UpdateBackupPolicyRequest()
            : base("polardbx", "2020-02-02", "UpdateBackupPolicy", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
			Method = MethodType.PUT;
        }

		private string dBInstanceName;

		private int? crossRegionDataBackupRetention;

		private int? forceCleanOnHighSpaceUsage;

		private string backupPlanBegin;

		private int? removeLogRetention;

		private int? coldDataBackupRetention;

		private int? localLogRetentionNumber;

		private string backupType;

		private int? isEnabled;

		private int? coldDataBackupInterval;

		private string backupWay;

		private string destCrossRegion;

		private int? backupSetRetention;

		private bool? isCrossRegionDataBackupEnabled;

		private int? crossRegionLogBackupRetention;

		private string backupPeriod;

		private bool? isCrossRegionLogBackupEnabled;

		private int? localLogRetention;

		private int? logLocalRetentionSpace;

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		public int? CrossRegionDataBackupRetention
		{
			get
			{
				return crossRegionDataBackupRetention;
			}
			set	
			{
				crossRegionDataBackupRetention = value;
				DictionaryUtil.Add(QueryParameters, "CrossRegionDataBackupRetention", value.ToString());
			}
		}

		public int? ForceCleanOnHighSpaceUsage
		{
			get
			{
				return forceCleanOnHighSpaceUsage;
			}
			set	
			{
				forceCleanOnHighSpaceUsage = value;
				DictionaryUtil.Add(QueryParameters, "ForceCleanOnHighSpaceUsage", value.ToString());
			}
		}

		public string BackupPlanBegin
		{
			get
			{
				return backupPlanBegin;
			}
			set	
			{
				backupPlanBegin = value;
				DictionaryUtil.Add(QueryParameters, "BackupPlanBegin", value);
			}
		}

		public int? RemoveLogRetention
		{
			get
			{
				return removeLogRetention;
			}
			set	
			{
				removeLogRetention = value;
				DictionaryUtil.Add(QueryParameters, "RemoveLogRetention", value.ToString());
			}
		}

		public int? ColdDataBackupRetention
		{
			get
			{
				return coldDataBackupRetention;
			}
			set	
			{
				coldDataBackupRetention = value;
				DictionaryUtil.Add(QueryParameters, "ColdDataBackupRetention", value.ToString());
			}
		}

		public int? LocalLogRetentionNumber
		{
			get
			{
				return localLogRetentionNumber;
			}
			set	
			{
				localLogRetentionNumber = value;
				DictionaryUtil.Add(QueryParameters, "LocalLogRetentionNumber", value.ToString());
			}
		}

		public string BackupType
		{
			get
			{
				return backupType;
			}
			set	
			{
				backupType = value;
				DictionaryUtil.Add(QueryParameters, "BackupType", value);
			}
		}

		public int? IsEnabled
		{
			get
			{
				return isEnabled;
			}
			set	
			{
				isEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IsEnabled", value.ToString());
			}
		}

		public int? ColdDataBackupInterval
		{
			get
			{
				return coldDataBackupInterval;
			}
			set	
			{
				coldDataBackupInterval = value;
				DictionaryUtil.Add(QueryParameters, "ColdDataBackupInterval", value.ToString());
			}
		}

		public string BackupWay
		{
			get
			{
				return backupWay;
			}
			set	
			{
				backupWay = value;
				DictionaryUtil.Add(QueryParameters, "BackupWay", value);
			}
		}

		public string DestCrossRegion
		{
			get
			{
				return destCrossRegion;
			}
			set	
			{
				destCrossRegion = value;
				DictionaryUtil.Add(QueryParameters, "DestCrossRegion", value);
			}
		}

		public int? BackupSetRetention
		{
			get
			{
				return backupSetRetention;
			}
			set	
			{
				backupSetRetention = value;
				DictionaryUtil.Add(QueryParameters, "BackupSetRetention", value.ToString());
			}
		}

		public bool? IsCrossRegionDataBackupEnabled
		{
			get
			{
				return isCrossRegionDataBackupEnabled;
			}
			set	
			{
				isCrossRegionDataBackupEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IsCrossRegionDataBackupEnabled", value.ToString());
			}
		}

		public int? CrossRegionLogBackupRetention
		{
			get
			{
				return crossRegionLogBackupRetention;
			}
			set	
			{
				crossRegionLogBackupRetention = value;
				DictionaryUtil.Add(QueryParameters, "CrossRegionLogBackupRetention", value.ToString());
			}
		}

		public string BackupPeriod
		{
			get
			{
				return backupPeriod;
			}
			set	
			{
				backupPeriod = value;
				DictionaryUtil.Add(QueryParameters, "BackupPeriod", value);
			}
		}

		public bool? IsCrossRegionLogBackupEnabled
		{
			get
			{
				return isCrossRegionLogBackupEnabled;
			}
			set	
			{
				isCrossRegionLogBackupEnabled = value;
				DictionaryUtil.Add(QueryParameters, "IsCrossRegionLogBackupEnabled", value.ToString());
			}
		}

		public int? LocalLogRetention
		{
			get
			{
				return localLogRetention;
			}
			set	
			{
				localLogRetention = value;
				DictionaryUtil.Add(QueryParameters, "LocalLogRetention", value.ToString());
			}
		}

		public int? LogLocalRetentionSpace
		{
			get
			{
				return logLocalRetentionSpace;
			}
			set	
			{
				logLocalRetentionSpace = value;
				DictionaryUtil.Add(QueryParameters, "LogLocalRetentionSpace", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateBackupPolicyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateBackupPolicyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
