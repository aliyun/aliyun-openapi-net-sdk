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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class GetDataExportDownloadURLResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private GetDataExportDownloadURL_DownloadURLResult downloadURLResult;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
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

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "DownloadURLResult")]
		public GetDataExportDownloadURL_DownloadURLResult DownloadURLResult
		{
			get
			{
				return downloadURLResult;
			}
			set	
			{
				downloadURLResult = value;
			}
		}

		public class GetDataExportDownloadURL_DownloadURLResult
		{

			private bool? hasResult;

			private string tipMessage;

			private string uRL;

			[JsonProperty(PropertyName = "HasResult")]
			public bool? HasResult
			{
				get
				{
					return hasResult;
				}
				set	
				{
					hasResult = value;
				}
			}

			[JsonProperty(PropertyName = "TipMessage")]
			public string TipMessage
			{
				get
				{
					return tipMessage;
				}
				set	
				{
					tipMessage = value;
				}
			}

			[JsonProperty(PropertyName = "URL")]
			public string URL
			{
				get
				{
					return uRL;
				}
				set	
				{
					uRL = value;
				}
			}
		}
	}
}
