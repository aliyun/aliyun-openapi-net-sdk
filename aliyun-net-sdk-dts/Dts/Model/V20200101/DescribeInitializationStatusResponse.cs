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
	public class DescribeInitializationStatusResponse : AcsResponse
	{

		private string errCode;

		private string errMessage;

		private string requestId;

		private string success;

		private List<DescribeInitializationStatus_DataInitializationDetail> dataInitializationDetails;

		private List<DescribeInitializationStatus_DataSynchronizationDetail> dataSynchronizationDetails;

		private List<DescribeInitializationStatus_StructureInitializationDetail> structureInitializationDetails;

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

		public List<DescribeInitializationStatus_DataInitializationDetail> DataInitializationDetails
		{
			get
			{
				return dataInitializationDetails;
			}
			set	
			{
				dataInitializationDetails = value;
			}
		}

		public List<DescribeInitializationStatus_DataSynchronizationDetail> DataSynchronizationDetails
		{
			get
			{
				return dataSynchronizationDetails;
			}
			set	
			{
				dataSynchronizationDetails = value;
			}
		}

		public List<DescribeInitializationStatus_StructureInitializationDetail> StructureInitializationDetails
		{
			get
			{
				return structureInitializationDetails;
			}
			set	
			{
				structureInitializationDetails = value;
			}
		}

		public class DescribeInitializationStatus_DataInitializationDetail
		{

			private string destinationOwnerDBName;

			private string errorMessage;

			private string finishRowNum;

			private string sourceOwnerDBName;

			private string status;

			private string tableName;

			private string totalRowNum;

			private string usedTime;

			public string DestinationOwnerDBName
			{
				get
				{
					return destinationOwnerDBName;
				}
				set	
				{
					destinationOwnerDBName = value;
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

			public string FinishRowNum
			{
				get
				{
					return finishRowNum;
				}
				set	
				{
					finishRowNum = value;
				}
			}

			public string SourceOwnerDBName
			{
				get
				{
					return sourceOwnerDBName;
				}
				set	
				{
					sourceOwnerDBName = value;
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

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}

			public string TotalRowNum
			{
				get
				{
					return totalRowNum;
				}
				set	
				{
					totalRowNum = value;
				}
			}

			public string UsedTime
			{
				get
				{
					return usedTime;
				}
				set	
				{
					usedTime = value;
				}
			}
		}

		public class DescribeInitializationStatus_DataSynchronizationDetail
		{

			private string destinationOwnerDBName;

			private string errorMessage;

			private string sourceOwnerDBName;

			private string status;

			private string tableName;

			public string DestinationOwnerDBName
			{
				get
				{
					return destinationOwnerDBName;
				}
				set	
				{
					destinationOwnerDBName = value;
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

			public string SourceOwnerDBName
			{
				get
				{
					return sourceOwnerDBName;
				}
				set	
				{
					sourceOwnerDBName = value;
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

			public string TableName
			{
				get
				{
					return tableName;
				}
				set	
				{
					tableName = value;
				}
			}
		}

		public class DescribeInitializationStatus_StructureInitializationDetail
		{

			private string destinationOwnerDBName;

			private string errorMessage;

			private string objectDefinition;

			private string objectName;

			private string objectType;

			private string sourceOwnerDBName;

			private string status;

			private List<DescribeInitializationStatus_StructureInitializationDetail1> constraints;

			public string DestinationOwnerDBName
			{
				get
				{
					return destinationOwnerDBName;
				}
				set	
				{
					destinationOwnerDBName = value;
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

			public string ObjectDefinition
			{
				get
				{
					return objectDefinition;
				}
				set	
				{
					objectDefinition = value;
				}
			}

			public string ObjectName
			{
				get
				{
					return objectName;
				}
				set	
				{
					objectName = value;
				}
			}

			public string ObjectType
			{
				get
				{
					return objectType;
				}
				set	
				{
					objectType = value;
				}
			}

			public string SourceOwnerDBName
			{
				get
				{
					return sourceOwnerDBName;
				}
				set	
				{
					sourceOwnerDBName = value;
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

			public List<DescribeInitializationStatus_StructureInitializationDetail1> Constraints
			{
				get
				{
					return constraints;
				}
				set	
				{
					constraints = value;
				}
			}

			public class DescribeInitializationStatus_StructureInitializationDetail1
			{

				private string destinationOwnerDBName;

				private string errorMessage;

				private string objectDefinition;

				private string objectName;

				private string objectType;

				private string sourceOwnerDBName;

				private string status;

				public string DestinationOwnerDBName
				{
					get
					{
						return destinationOwnerDBName;
					}
					set	
					{
						destinationOwnerDBName = value;
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

				public string ObjectDefinition
				{
					get
					{
						return objectDefinition;
					}
					set	
					{
						objectDefinition = value;
					}
				}

				public string ObjectName
				{
					get
					{
						return objectName;
					}
					set	
					{
						objectName = value;
					}
				}

				public string ObjectType
				{
					get
					{
						return objectType;
					}
					set	
					{
						objectType = value;
					}
				}

				public string SourceOwnerDBName
				{
					get
					{
						return sourceOwnerDBName;
					}
					set	
					{
						sourceOwnerDBName = value;
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
}
