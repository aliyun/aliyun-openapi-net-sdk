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

namespace Aliyun.Acs.Cloudauth.Model.V20180916
{
	public class SubmitVerificationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string message;

		private SubmitVerification_Data data;

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

		public SubmitVerification_Data Data
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

		public class SubmitVerification_Data
		{

			private SubmitVerification_VerifyStatus verifyStatus;

			public SubmitVerification_VerifyStatus VerifyStatus
			{
				get
				{
					return verifyStatus;
				}
				set	
				{
					verifyStatus = value;
				}
			}

			public class SubmitVerification_VerifyStatus
			{

				private int? statusCode;

				private float? trustedScore;

				private float? similarityScore;

				private string auditConclusions;

				private float? authorityComparisonScore;

				public int? StatusCode
				{
					get
					{
						return statusCode;
					}
					set	
					{
						statusCode = value;
					}
				}

				public float? TrustedScore
				{
					get
					{
						return trustedScore;
					}
					set	
					{
						trustedScore = value;
					}
				}

				public float? SimilarityScore
				{
					get
					{
						return similarityScore;
					}
					set	
					{
						similarityScore = value;
					}
				}

				public string AuditConclusions
				{
					get
					{
						return auditConclusions;
					}
					set	
					{
						auditConclusions = value;
					}
				}

				public float? AuthorityComparisonScore
				{
					get
					{
						return authorityComparisonScore;
					}
					set	
					{
						authorityComparisonScore = value;
					}
				}
			}
		}
	}
}