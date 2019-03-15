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

namespace Aliyun.Acs.Mts.Model.V20140618
{
	public class SubmitSubtitleJobResponse : AcsResponse
	{

		private string requestId;

		private SubmitSubtitleJob_SubtitleJob subtitleJob;

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

		public SubmitSubtitleJob_SubtitleJob SubtitleJob
		{
			get
			{
				return subtitleJob;
			}
			set	
			{
				subtitleJob = value;
			}
		}

		public class SubmitSubtitleJob_SubtitleJob
		{

			private string jobId;

			private string inputConfig;

			private string inputConfig1;

			private string userData;

			private string state;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string InputConfig
			{
				get
				{
					return inputConfig;
				}
				set	
				{
					inputConfig = value;
				}
			}

			public string InputConfig1
			{
				get
				{
					return inputConfig1;
				}
				set	
				{
					inputConfig1 = value;
				}
			}

			public string UserData
			{
				get
				{
					return userData;
				}
				set	
				{
					userData = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}
		}
	}
}
