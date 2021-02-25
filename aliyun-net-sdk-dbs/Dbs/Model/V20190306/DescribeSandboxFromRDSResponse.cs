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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribeSandboxFromRDSResponse : AcsResponse
	{

		private bool? success;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private string requestId;

		private string sourceId;

		private string backupPlanName;

		private string backupLog;

		private string dbsInstanceId;

		private bool? supportSandbox;

		private int? sandboxInstanceCount;

		private long? sandboxRecoverStartTime;

		private long? sandboxRecoverEndTime;

		private bool? enabledSandbox;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string SourceId
		{
			get
			{
				return sourceId;
			}
			set	
			{
				sourceId = value;
			}
		}

		public string BackupPlanName
		{
			get
			{
				return backupPlanName;
			}
			set	
			{
				backupPlanName = value;
			}
		}

		public string BackupLog
		{
			get
			{
				return backupLog;
			}
			set	
			{
				backupLog = value;
			}
		}

		public string DbsInstanceId
		{
			get
			{
				return dbsInstanceId;
			}
			set	
			{
				dbsInstanceId = value;
			}
		}

		public bool? SupportSandbox
		{
			get
			{
				return supportSandbox;
			}
			set	
			{
				supportSandbox = value;
			}
		}

		public int? SandboxInstanceCount
		{
			get
			{
				return sandboxInstanceCount;
			}
			set	
			{
				sandboxInstanceCount = value;
			}
		}

		public long? SandboxRecoverStartTime
		{
			get
			{
				return sandboxRecoverStartTime;
			}
			set	
			{
				sandboxRecoverStartTime = value;
			}
		}

		public long? SandboxRecoverEndTime
		{
			get
			{
				return sandboxRecoverEndTime;
			}
			set	
			{
				sandboxRecoverEndTime = value;
			}
		}

		public bool? EnabledSandbox
		{
			get
			{
				return enabledSandbox;
			}
			set	
			{
				enabledSandbox = value;
			}
		}
	}
}
