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

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
	public class UpgradeEngineVersionResponse : AcsResponse
	{

		private string requestId;

		private UpgradeEngineVersion_Result result;

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

		public UpgradeEngineVersion_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class UpgradeEngineVersion_Result
		{

			private string validateType;

			private string status;

			private UpgradeEngineVersion_ValidateResult validateResult;

			public string ValidateType
			{
				get
				{
					return validateType;
				}
				set	
				{
					validateType = value;
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

			public UpgradeEngineVersion_ValidateResult ValidateResult
			{
				get
				{
					return validateResult;
				}
				set	
				{
					validateResult = value;
				}
			}

			public class UpgradeEngineVersion_ValidateResult
			{

				private string errorType;

				private string errorCode;

				private string errorMsg;

				public string ErrorType
				{
					get
					{
						return errorType;
					}
					set	
					{
						errorType = value;
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

				public string ErrorMsg
				{
					get
					{
						return errorMsg;
					}
					set	
					{
						errorMsg = value;
					}
				}
			}
		}
	}
}
