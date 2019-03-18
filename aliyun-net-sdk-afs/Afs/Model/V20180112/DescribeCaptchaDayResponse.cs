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

namespace Aliyun.Acs.afs.Model.V20180112
{
	public class DescribeCaptchaDayResponse : AcsResponse
	{

		private string requestId;

		private string bizCode;

		private bool? hasData;

		private DescribeCaptchaDay_CaptchaDay captchaDay;

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

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
			}
		}

		public bool? HasData
		{
			get
			{
				return hasData;
			}
			set	
			{
				hasData = value;
			}
		}

		public DescribeCaptchaDay_CaptchaDay CaptchaDay
		{
			get
			{
				return captchaDay;
			}
			set	
			{
				captchaDay = value;
			}
		}

		public class DescribeCaptchaDay_CaptchaDay
		{

			private int? init;

			private int? askForVerify;

			private int? direcetStrategyInterception;

			private int? twiceVerify;

			private int? pass;

			private int? checkTested;

			private int? uncheckTested;

			private int? legalSign;

			private int? maliciousFlow;

			public int? Init
			{
				get
				{
					return init;
				}
				set	
				{
					init = value;
				}
			}

			public int? AskForVerify
			{
				get
				{
					return askForVerify;
				}
				set	
				{
					askForVerify = value;
				}
			}

			public int? DirecetStrategyInterception
			{
				get
				{
					return direcetStrategyInterception;
				}
				set	
				{
					direcetStrategyInterception = value;
				}
			}

			public int? TwiceVerify
			{
				get
				{
					return twiceVerify;
				}
				set	
				{
					twiceVerify = value;
				}
			}

			public int? Pass
			{
				get
				{
					return pass;
				}
				set	
				{
					pass = value;
				}
			}

			public int? CheckTested
			{
				get
				{
					return checkTested;
				}
				set	
				{
					checkTested = value;
				}
			}

			public int? UncheckTested
			{
				get
				{
					return uncheckTested;
				}
				set	
				{
					uncheckTested = value;
				}
			}

			public int? LegalSign
			{
				get
				{
					return legalSign;
				}
				set	
				{
					legalSign = value;
				}
			}

			public int? MaliciousFlow
			{
				get
				{
					return maliciousFlow;
				}
				set	
				{
					maliciousFlow = value;
				}
			}
		}
	}
}
