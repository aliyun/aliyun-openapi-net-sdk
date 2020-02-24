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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeNavigationConfigResponse : AcsResponse
	{

		private string requestId;

		private DescribeNavigationConfig_GreetingConfig greetingConfig;

		private DescribeNavigationConfig_UnrecognizingConfig unrecognizingConfig;

		private DescribeNavigationConfig_RepeatingConfig repeatingConfig;

		private DescribeNavigationConfig_AskingBackConfig askingBackConfig;

		private DescribeNavigationConfig_ComplainingConfig complainingConfig;

		private DescribeNavigationConfig_SilenceTimeoutConfig silenceTimeoutConfig;

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

		public DescribeNavigationConfig_GreetingConfig GreetingConfig
		{
			get
			{
				return greetingConfig;
			}
			set	
			{
				greetingConfig = value;
			}
		}

		public DescribeNavigationConfig_UnrecognizingConfig UnrecognizingConfig
		{
			get
			{
				return unrecognizingConfig;
			}
			set	
			{
				unrecognizingConfig = value;
			}
		}

		public DescribeNavigationConfig_RepeatingConfig RepeatingConfig
		{
			get
			{
				return repeatingConfig;
			}
			set	
			{
				repeatingConfig = value;
			}
		}

		public DescribeNavigationConfig_AskingBackConfig AskingBackConfig
		{
			get
			{
				return askingBackConfig;
			}
			set	
			{
				askingBackConfig = value;
			}
		}

		public DescribeNavigationConfig_ComplainingConfig ComplainingConfig
		{
			get
			{
				return complainingConfig;
			}
			set	
			{
				complainingConfig = value;
			}
		}

		public DescribeNavigationConfig_SilenceTimeoutConfig SilenceTimeoutConfig
		{
			get
			{
				return silenceTimeoutConfig;
			}
			set	
			{
				silenceTimeoutConfig = value;
			}
		}

		public class DescribeNavigationConfig_GreetingConfig
		{

			private string greetingWords;

			private string sourceType;

			private string intentTrigger;

			public string GreetingWords
			{
				get
				{
					return greetingWords;
				}
				set	
				{
					greetingWords = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string IntentTrigger
			{
				get
				{
					return intentTrigger;
				}
				set	
				{
					intentTrigger = value;
				}
			}
		}

		public class DescribeNavigationConfig_UnrecognizingConfig
		{

			private string prompt;

			private int? threshold;

			private string finalPrompt;

			private string finalAction;

			private string finalActionParams;

			public string Prompt
			{
				get
				{
					return prompt;
				}
				set	
				{
					prompt = value;
				}
			}

			public int? Threshold
			{
				get
				{
					return threshold;
				}
				set	
				{
					threshold = value;
				}
			}

			public string FinalPrompt
			{
				get
				{
					return finalPrompt;
				}
				set	
				{
					finalPrompt = value;
				}
			}

			public string FinalAction
			{
				get
				{
					return finalAction;
				}
				set	
				{
					finalAction = value;
				}
			}

			public string FinalActionParams
			{
				get
				{
					return finalActionParams;
				}
				set	
				{
					finalActionParams = value;
				}
			}
		}

		public class DescribeNavigationConfig_RepeatingConfig
		{

			private List<string> utterances;

			public List<string> Utterances
			{
				get
				{
					return utterances;
				}
				set	
				{
					utterances = value;
				}
			}
		}

		public class DescribeNavigationConfig_AskingBackConfig
		{

			private bool? enabled;

			private string prompt;

			private bool? enableNegativeFeedback;

			private string negativeFeedbackPrompt;

			private string negativeFeedbackAction;

			private string negativeFeedbackActionParams;

			private List<string> negativeFeedbackUtterances;

			public bool? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
				}
			}

			public string Prompt
			{
				get
				{
					return prompt;
				}
				set	
				{
					prompt = value;
				}
			}

			public bool? EnableNegativeFeedback
			{
				get
				{
					return enableNegativeFeedback;
				}
				set	
				{
					enableNegativeFeedback = value;
				}
			}

			public string NegativeFeedbackPrompt
			{
				get
				{
					return negativeFeedbackPrompt;
				}
				set	
				{
					negativeFeedbackPrompt = value;
				}
			}

			public string NegativeFeedbackAction
			{
				get
				{
					return negativeFeedbackAction;
				}
				set	
				{
					negativeFeedbackAction = value;
				}
			}

			public string NegativeFeedbackActionParams
			{
				get
				{
					return negativeFeedbackActionParams;
				}
				set	
				{
					negativeFeedbackActionParams = value;
				}
			}

			public List<string> NegativeFeedbackUtterances
			{
				get
				{
					return negativeFeedbackUtterances;
				}
				set	
				{
					negativeFeedbackUtterances = value;
				}
			}
		}

		public class DescribeNavigationConfig_ComplainingConfig
		{

			private string prompt;

			private string finalAction;

			private string finalActionParams;

			private List<string> utterances1;

			public string Prompt
			{
				get
				{
					return prompt;
				}
				set	
				{
					prompt = value;
				}
			}

			public string FinalAction
			{
				get
				{
					return finalAction;
				}
				set	
				{
					finalAction = value;
				}
			}

			public string FinalActionParams
			{
				get
				{
					return finalActionParams;
				}
				set	
				{
					finalActionParams = value;
				}
			}

			public List<string> Utterances1
			{
				get
				{
					return utterances1;
				}
				set	
				{
					utterances1 = value;
				}
			}
		}

		public class DescribeNavigationConfig_SilenceTimeoutConfig
		{

			private string prompt;

			private long? timeout;

			private int? threshold;

			private string finalPrompt;

			private string finalAction;

			private string finalActionParams;

			private string sourceType;

			private string intentTrigger;

			public string Prompt
			{
				get
				{
					return prompt;
				}
				set	
				{
					prompt = value;
				}
			}

			public long? Timeout
			{
				get
				{
					return timeout;
				}
				set	
				{
					timeout = value;
				}
			}

			public int? Threshold
			{
				get
				{
					return threshold;
				}
				set	
				{
					threshold = value;
				}
			}

			public string FinalPrompt
			{
				get
				{
					return finalPrompt;
				}
				set	
				{
					finalPrompt = value;
				}
			}

			public string FinalAction
			{
				get
				{
					return finalAction;
				}
				set	
				{
					finalAction = value;
				}
			}

			public string FinalActionParams
			{
				get
				{
					return finalActionParams;
				}
				set	
				{
					finalActionParams = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}

			public string IntentTrigger
			{
				get
				{
					return intentTrigger;
				}
				set	
				{
					intentTrigger = value;
				}
			}
		}
	}
}
