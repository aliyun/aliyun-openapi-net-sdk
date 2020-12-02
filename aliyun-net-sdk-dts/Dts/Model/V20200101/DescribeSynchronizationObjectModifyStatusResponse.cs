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

namespace Aliyun.Acs.Dts.Model.V20200101
{
	public class DescribeSynchronizationObjectModifyStatusResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private string errorMessage;

		private string requestId;

		private string status;

		private string success;

		private DescribeSynchronizationObjectModifyStatus_DataInitializationStatus dataInitializationStatus;

		private DescribeSynchronizationObjectModifyStatus_DataSynchronizationStatus dataSynchronizationStatus;

		private DescribeSynchronizationObjectModifyStatus_PrecheckStatus precheckStatus;

		private DescribeSynchronizationObjectModifyStatus_StructureInitializationStatus structureInitializationStatus;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string Success
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

		public DescribeSynchronizationObjectModifyStatus_DataInitializationStatus DataInitializationStatus
		{
			get
			{
				return dataInitializationStatus;
			}
			set	
			{
				dataInitializationStatus = value;
			}
		}

		public DescribeSynchronizationObjectModifyStatus_DataSynchronizationStatus DataSynchronizationStatus
		{
			get
			{
				return dataSynchronizationStatus;
			}
			set	
			{
				dataSynchronizationStatus = value;
			}
		}

		public DescribeSynchronizationObjectModifyStatus_PrecheckStatus PrecheckStatus
		{
			get
			{
				return precheckStatus;
			}
			set	
			{
				precheckStatus = value;
			}
		}

		public DescribeSynchronizationObjectModifyStatus_StructureInitializationStatus StructureInitializationStatus
		{
			get
			{
				return structureInitializationStatus;
			}
			set	
			{
				structureInitializationStatus = value;
			}
		}

		public class DescribeSynchronizationObjectModifyStatus_DataInitializationStatus
		{

			private string errorMessage;

			private string percent;

			private string progress;

			private string status;

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}

		public class DescribeSynchronizationObjectModifyStatus_DataSynchronizationStatus
		{

			private string delay;

			private string errorMessage;

			private string percent;

			private string status;

			public string Delay
			{
				get
				{
					return delay;
				}
				set	
				{
					delay = value;
				}
			}

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}

		public class DescribeSynchronizationObjectModifyStatus_PrecheckStatus
		{

			private string percent;

			private string status;

			private List<DescribeSynchronizationObjectModifyStatus_CheckItem> detail;

			public string Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public List<DescribeSynchronizationObjectModifyStatus_CheckItem> Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}

			public class DescribeSynchronizationObjectModifyStatus_CheckItem
			{

				private string checkStatus;

				private string errorMessage;

				private string itemName;

				private string repairMethod;

				public string CheckStatus
				{
					get
					{
						return checkStatus;
					}
					set	
					{
						checkStatus = value;
					}
				}

				public string ErrorMessage
				{
					get
					{
						return errorMessage;
					}
					set	
					{
						errorMessage = value;
					}
				}

				public string ItemName
				{
					get
					{
						return itemName;
					}
					set	
					{
						itemName = value;
					}
				}

				public string RepairMethod
				{
					get
					{
						return repairMethod;
					}
					set	
					{
						repairMethod = value;
					}
				}
			}
		}

		public class DescribeSynchronizationObjectModifyStatus_StructureInitializationStatus
		{

			private string errorMessage;

			private string percent;

			private string progress;

			private string status;

			public string ErrorMessage
			{
				get
				{
					return errorMessage;
				}
				set	
				{
					errorMessage = value;
				}
			}

			public string Percent
			{
				get
				{
					return percent;
				}
				set	
				{
					percent = value;
				}
			}

			public string Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}
	}
}
