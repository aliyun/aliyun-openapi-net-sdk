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

namespace Aliyun.Acs.CCC.Model.V20170705
{
	public class PreCreateMediaResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private int? httpStatusCode;

		private PreCreateMedia_PreCreateMediaParam preCreateMediaParam;

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

		public PreCreateMedia_PreCreateMediaParam PreCreateMediaParam
		{
			get
			{
				return preCreateMediaParam;
			}
			set	
			{
				preCreateMediaParam = value;
			}
		}

		public class PreCreateMedia_PreCreateMediaParam
		{

			private string ossFile;

			private string ossFilePath;

			private string ossBucket;

			private string signatureUrl;

			public string OssFile
			{
				get
				{
					return ossFile;
				}
				set	
				{
					ossFile = value;
				}
			}

			public string OssFilePath
			{
				get
				{
					return ossFilePath;
				}
				set	
				{
					ossFilePath = value;
				}
			}

			public string OssBucket
			{
				get
				{
					return ossBucket;
				}
				set	
				{
					ossBucket = value;
				}
			}

			public string SignatureUrl
			{
				get
				{
					return signatureUrl;
				}
				set	
				{
					signatureUrl = value;
				}
			}
		}
	}
}
