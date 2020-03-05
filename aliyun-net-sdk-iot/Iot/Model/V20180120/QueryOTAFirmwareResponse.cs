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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryOTAFirmwareResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryOTAFirmware_FirmwareInfo firmwareInfo;

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

		public QueryOTAFirmware_FirmwareInfo FirmwareInfo
		{
			get
			{
				return firmwareInfo;
			}
			set	
			{
				firmwareInfo = value;
			}
		}

		public class QueryOTAFirmware_FirmwareInfo
		{

			private string firmwareName;

			private string firmwareId;

			private string srcVersion;

			private string destVersion;

			private string utcCreate;

			private string utcModified;

			private int? status;

			private string firmwareDesc;

			private string firmwareSign;

			private int? firmwareSize;

			private string firmwareUrl;

			private string productKey;

			private string signMethod;

			private string productName;

			private int? type;

			private int? verifyProgress;

			private string moduleName;

			public string FirmwareName
			{
				get
				{
					return firmwareName;
				}
				set	
				{
					firmwareName = value;
				}
			}

			public string FirmwareId
			{
				get
				{
					return firmwareId;
				}
				set	
				{
					firmwareId = value;
				}
			}

			public string SrcVersion
			{
				get
				{
					return srcVersion;
				}
				set	
				{
					srcVersion = value;
				}
			}

			public string DestVersion
			{
				get
				{
					return destVersion;
				}
				set	
				{
					destVersion = value;
				}
			}

			public string UtcCreate
			{
				get
				{
					return utcCreate;
				}
				set	
				{
					utcCreate = value;
				}
			}

			public string UtcModified
			{
				get
				{
					return utcModified;
				}
				set	
				{
					utcModified = value;
				}
			}

			public int? Status
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

			public string FirmwareDesc
			{
				get
				{
					return firmwareDesc;
				}
				set	
				{
					firmwareDesc = value;
				}
			}

			public string FirmwareSign
			{
				get
				{
					return firmwareSign;
				}
				set	
				{
					firmwareSign = value;
				}
			}

			public int? FirmwareSize
			{
				get
				{
					return firmwareSize;
				}
				set	
				{
					firmwareSize = value;
				}
			}

			public string FirmwareUrl
			{
				get
				{
					return firmwareUrl;
				}
				set	
				{
					firmwareUrl = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string SignMethod
			{
				get
				{
					return signMethod;
				}
				set	
				{
					signMethod = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public int? Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public int? VerifyProgress
			{
				get
				{
					return verifyProgress;
				}
				set	
				{
					verifyProgress = value;
				}
			}

			public string ModuleName
			{
				get
				{
					return moduleName;
				}
				set	
				{
					moduleName = value;
				}
			}
		}
	}
}
