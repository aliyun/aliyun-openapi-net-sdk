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

namespace Aliyun.Acs.Cloudauth.Model.V20201112
{
	public class LivenessDetectResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private LivenessDetect_ResultObject resultObject;

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

		public LivenessDetect_ResultObject ResultObject
		{
			get
			{
				return resultObject;
			}
			set	
			{
				resultObject = value;
			}
		}

		public class LivenessDetect_ResultObject
		{

			private string passed;

			private float? score;

			private string frameUrl;

			public string Passed
			{
				get
				{
					return passed;
				}
				set	
				{
					passed = value;
				}
			}

			public float? Score
			{
				get
				{
					return score;
				}
				set	
				{
					score = value;
				}
			}

			public string FrameUrl
			{
				get
				{
					return frameUrl;
				}
				set	
				{
					frameUrl = value;
				}
			}
		}
	}
}
