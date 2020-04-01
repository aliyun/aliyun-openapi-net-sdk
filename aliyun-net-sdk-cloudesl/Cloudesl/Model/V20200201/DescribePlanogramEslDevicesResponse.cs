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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribePlanogramEslDevicesResponse : AcsResponse
	{

		private string code;

		private string dynamicCode;

		private string dynamicMessage;

		private string errorCode;

		private string errorMessage;

		private string message;

		private string requestId;

		private string shelf;

		private string storeId;

		private bool? success;

		private List<DescribePlanogramEslDevices_EslDeviceLayerInfo> eslDeviceLayerInfos;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public string Shelf
		{
			get
			{
				return shelf;
			}
			set	
			{
				shelf = value;
			}
		}

		public string StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
			}
		}

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

		public List<DescribePlanogramEslDevices_EslDeviceLayerInfo> EslDeviceLayerInfos
		{
			get
			{
				return eslDeviceLayerInfos;
			}
			set	
			{
				eslDeviceLayerInfos = value;
			}
		}

		public class DescribePlanogramEslDevices_EslDeviceLayerInfo
		{

			private int? layer;

			private List<DescribePlanogramEslDevices_EslDevicePositionInfo> eslDevicePositionInfos;

			public int? Layer
			{
				get
				{
					return layer;
				}
				set	
				{
					layer = value;
				}
			}

			public List<DescribePlanogramEslDevices_EslDevicePositionInfo> EslDevicePositionInfos
			{
				get
				{
					return eslDevicePositionInfos;
				}
				set	
				{
					eslDevicePositionInfos = value;
				}
			}

			public class DescribePlanogramEslDevices_EslDevicePositionInfo
			{

				private string column;

				private List<DescribePlanogramEslDevices_EslDevicePlanogramInfo> eslDevicePlanogramInfos;

				public string Column
				{
					get
					{
						return column;
					}
					set	
					{
						column = value;
					}
				}

				public List<DescribePlanogramEslDevices_EslDevicePlanogramInfo> EslDevicePlanogramInfos
				{
					get
					{
						return eslDevicePlanogramInfos;
					}
					set	
					{
						eslDevicePlanogramInfos = value;
					}
				}

				public class DescribePlanogramEslDevices_EslDevicePlanogramInfo
				{

					private string eslBarCode;

					private string eslModel;

					private string itemBarCode;

					private string itemTitle;

					public string EslBarCode
					{
						get
						{
							return eslBarCode;
						}
						set	
						{
							eslBarCode = value;
						}
					}

					public string EslModel
					{
						get
						{
							return eslModel;
						}
						set	
						{
							eslModel = value;
						}
					}

					public string ItemBarCode
					{
						get
						{
							return itemBarCode;
						}
						set	
						{
							itemBarCode = value;
						}
					}

					public string ItemTitle
					{
						get
						{
							return itemTitle;
						}
						set	
						{
							itemTitle = value;
						}
					}
				}
			}
		}
	}
}
