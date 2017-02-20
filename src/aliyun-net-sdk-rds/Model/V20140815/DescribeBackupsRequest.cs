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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class DescribeBackupsRequest : RpcAcsRequest<DescribeBackupsResponse>
    {
        public DescribeBackupsRequest()
            : base("Rds", "2014-08-15", "DescribeBackups")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _dBInstanceId;

		private string _backupId;

		private string _backupLocation;

		private string _backupStatus;

		private string _backupMode;

		private string _startTime;

		private string _endTime;

		private int? _pageSize;

		private int? _pageNumber;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string DBInstanceId
		{
			get
			{
				return _dBInstanceId;
			}
			set	
			{
				_dBInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceId", value);
			}
		}

		public string BackupId
		{
			get
			{
				return _backupId;
			}
			set	
			{
				_backupId = value;
				DictionaryUtil.Add(QueryParameters, "BackupId", value);
			}
		}

		public string BackupLocation
		{
			get
			{
				return _backupLocation;
			}
			set	
			{
				_backupLocation = value;
				DictionaryUtil.Add(QueryParameters, "BackupLocation", value);
			}
		}

		public string BackupStatus
		{
			get
			{
				return _backupStatus;
			}
			set	
			{
				_backupStatus = value;
				DictionaryUtil.Add(QueryParameters, "BackupStatus", value);
			}
		}

		public string BackupMode
		{
			get
			{
				return _backupMode;
			}
			set	
			{
				_backupMode = value;
				DictionaryUtil.Add(QueryParameters, "BackupMode", value);
			}
		}

		public string StartTime
		{
			get
			{
				return _startTime;
			}
			set	
			{
				_startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string EndTime
		{
			get
			{
				return _endTime;
			}
			set	
			{
				_endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override DescribeBackupsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeBackupsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}