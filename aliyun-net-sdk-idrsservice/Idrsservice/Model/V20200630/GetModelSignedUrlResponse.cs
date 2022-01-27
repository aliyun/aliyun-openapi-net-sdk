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

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
	public class GetModelSignedUrlResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<GetModelSignedUrl_DataItem> data;

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

		public List<GetModelSignedUrl_DataItem> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetModelSignedUrl_DataItem
		{

			private string modelPath;

			private string publicUrl;

			private string md5;

			public string ModelPath
			{
				get
				{
					return modelPath;
				}
				set	
				{
					modelPath = value;
				}
			}

			public string PublicUrl
			{
				get
				{
					return publicUrl;
				}
				set	
				{
					publicUrl = value;
				}
			}

			public string Md5
			{
				get
				{
					return md5;
				}
				set	
				{
					md5 = value;
				}
			}
		}
	}
}
