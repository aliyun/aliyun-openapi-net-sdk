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

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
	public class ScaleAppResponse : AcsResponse
	{

		private int? code;

		private string errMsg;

		private string requestId;

		private bool? success;

		private ScaleApp_Result result;

		public int? Code
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

		public string ErrMsg
		{
			get
			{
				return errMsg;
			}
			set	
			{
				errMsg = value;
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

		public ScaleApp_Result Result
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

		public class ScaleApp_Result
		{

			private bool? admitted;

			private string businessCode;

			private long? deployOrderId;

			public bool? Admitted
			{
				get
				{
					return admitted;
				}
				set	
				{
					admitted = value;
				}
			}

			public string BusinessCode
			{
				get
				{
					return businessCode;
				}
				set	
				{
					businessCode = value;
				}
			}

			public long? DeployOrderId
			{
				get
				{
					return deployOrderId;
				}
				set	
				{
					deployOrderId = value;
				}
			}
		}
	}
}
