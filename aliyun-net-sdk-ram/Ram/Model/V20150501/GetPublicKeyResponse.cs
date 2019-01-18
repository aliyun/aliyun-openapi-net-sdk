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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ram.Model.V20150501
{
	public class GetPublicKeyResponse : AcsResponse
	{

		private string requestId;

		private GetPublicKey_PublicKey publicKey;

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

		public GetPublicKey_PublicKey PublicKey
		{
			get
			{
				return publicKey;
			}
			set	
			{
				publicKey = value;
			}
		}

		public class GetPublicKey_PublicKey
		{

			private string publicKeyId;

			private string publicKeySpec;

			private string status;

			private string createDate;

			public string PublicKeyId
			{
				get
				{
					return publicKeyId;
				}
				set	
				{
					publicKeyId = value;
				}
			}

			public string PublicKeySpec
			{
				get
				{
					return publicKeySpec;
				}
				set	
				{
					publicKeySpec = value;
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

			public string CreateDate
			{
				get
				{
					return createDate;
				}
				set	
				{
					createDate = value;
				}
			}
		}
	}
}