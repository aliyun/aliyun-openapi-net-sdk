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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeNavigationConfigResponseUnmarshaller
    {
        public static DescribeNavigationConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNavigationConfigResponse describeNavigationConfigResponse = new DescribeNavigationConfigResponse();

			describeNavigationConfigResponse.HttpResponse = context.HttpResponse;
			describeNavigationConfigResponse.RequestId = context.StringValue("DescribeNavigationConfig.RequestId");

			DescribeNavigationConfigResponse.DescribeNavigationConfig_GreetingConfig greetingConfig = new DescribeNavigationConfigResponse.DescribeNavigationConfig_GreetingConfig();
			greetingConfig.GreetingWords = context.StringValue("DescribeNavigationConfig.GreetingConfig.GreetingWords");
			greetingConfig.SourceType = context.StringValue("DescribeNavigationConfig.GreetingConfig.SourceType");
			greetingConfig.IntentTrigger = context.StringValue("DescribeNavigationConfig.GreetingConfig.IntentTrigger");
			describeNavigationConfigResponse.GreetingConfig = greetingConfig;

			DescribeNavigationConfigResponse.DescribeNavigationConfig_UnrecognizingConfig unrecognizingConfig = new DescribeNavigationConfigResponse.DescribeNavigationConfig_UnrecognizingConfig();
			unrecognizingConfig.Prompt = context.StringValue("DescribeNavigationConfig.UnrecognizingConfig.Prompt");
			unrecognizingConfig.Threshold = context.IntegerValue("DescribeNavigationConfig.UnrecognizingConfig.Threshold");
			unrecognizingConfig.FinalPrompt = context.StringValue("DescribeNavigationConfig.UnrecognizingConfig.FinalPrompt");
			unrecognizingConfig.FinalAction = context.StringValue("DescribeNavigationConfig.UnrecognizingConfig.FinalAction");
			unrecognizingConfig.FinalActionParams = context.StringValue("DescribeNavigationConfig.UnrecognizingConfig.FinalActionParams");
			describeNavigationConfigResponse.UnrecognizingConfig = unrecognizingConfig;

			DescribeNavigationConfigResponse.DescribeNavigationConfig_RepeatingConfig repeatingConfig = new DescribeNavigationConfigResponse.DescribeNavigationConfig_RepeatingConfig();

			List<string> repeatingConfig_utterances = new List<string>();
			for (int i = 0; i < context.Length("DescribeNavigationConfig.RepeatingConfig.Utterances.Length"); i++) {
				repeatingConfig_utterances.Add(context.StringValue("DescribeNavigationConfig.RepeatingConfig.Utterances["+ i +"]"));
			}
			repeatingConfig.Utterances = repeatingConfig_utterances;
			describeNavigationConfigResponse.RepeatingConfig = repeatingConfig;

			DescribeNavigationConfigResponse.DescribeNavigationConfig_AskingBackConfig askingBackConfig = new DescribeNavigationConfigResponse.DescribeNavigationConfig_AskingBackConfig();
			askingBackConfig.Enabled = context.BooleanValue("DescribeNavigationConfig.AskingBackConfig.Enabled");
			askingBackConfig.Prompt = context.StringValue("DescribeNavigationConfig.AskingBackConfig.Prompt");
			askingBackConfig.EnableNegativeFeedback = context.BooleanValue("DescribeNavigationConfig.AskingBackConfig.EnableNegativeFeedback");
			askingBackConfig.NegativeFeedbackPrompt = context.StringValue("DescribeNavigationConfig.AskingBackConfig.NegativeFeedbackPrompt");
			askingBackConfig.NegativeFeedbackAction = context.StringValue("DescribeNavigationConfig.AskingBackConfig.NegativeFeedbackAction");
			askingBackConfig.NegativeFeedbackActionParams = context.StringValue("DescribeNavigationConfig.AskingBackConfig.NegativeFeedbackActionParams");

			List<string> askingBackConfig_negativeFeedbackUtterances = new List<string>();
			for (int i = 0; i < context.Length("DescribeNavigationConfig.AskingBackConfig.NegativeFeedbackUtterances.Length"); i++) {
				askingBackConfig_negativeFeedbackUtterances.Add(context.StringValue("DescribeNavigationConfig.AskingBackConfig.NegativeFeedbackUtterances["+ i +"]"));
			}
			askingBackConfig.NegativeFeedbackUtterances = askingBackConfig_negativeFeedbackUtterances;
			describeNavigationConfigResponse.AskingBackConfig = askingBackConfig;

			DescribeNavigationConfigResponse.DescribeNavigationConfig_ComplainingConfig complainingConfig = new DescribeNavigationConfigResponse.DescribeNavigationConfig_ComplainingConfig();
			complainingConfig.Prompt = context.StringValue("DescribeNavigationConfig.ComplainingConfig.Prompt");
			complainingConfig.FinalAction = context.StringValue("DescribeNavigationConfig.ComplainingConfig.FinalAction");
			complainingConfig.FinalActionParams = context.StringValue("DescribeNavigationConfig.ComplainingConfig.FinalActionParams");

			List<string> complainingConfig_utterances1 = new List<string>();
			for (int i = 0; i < context.Length("DescribeNavigationConfig.ComplainingConfig.Utterances.Length"); i++) {
				complainingConfig_utterances1.Add(context.StringValue("DescribeNavigationConfig.ComplainingConfig.Utterances["+ i +"]"));
			}
			complainingConfig.Utterances1 = complainingConfig_utterances1;
			describeNavigationConfigResponse.ComplainingConfig = complainingConfig;

			DescribeNavigationConfigResponse.DescribeNavigationConfig_SilenceTimeoutConfig silenceTimeoutConfig = new DescribeNavigationConfigResponse.DescribeNavigationConfig_SilenceTimeoutConfig();
			silenceTimeoutConfig.Prompt = context.StringValue("DescribeNavigationConfig.SilenceTimeoutConfig.Prompt");
			silenceTimeoutConfig.Timeout = context.LongValue("DescribeNavigationConfig.SilenceTimeoutConfig.Timeout");
			silenceTimeoutConfig.Threshold = context.IntegerValue("DescribeNavigationConfig.SilenceTimeoutConfig.Threshold");
			silenceTimeoutConfig.FinalPrompt = context.StringValue("DescribeNavigationConfig.SilenceTimeoutConfig.FinalPrompt");
			silenceTimeoutConfig.FinalAction = context.StringValue("DescribeNavigationConfig.SilenceTimeoutConfig.FinalAction");
			silenceTimeoutConfig.FinalActionParams = context.StringValue("DescribeNavigationConfig.SilenceTimeoutConfig.FinalActionParams");
			silenceTimeoutConfig.SourceType = context.StringValue("DescribeNavigationConfig.SilenceTimeoutConfig.SourceType");
			silenceTimeoutConfig.IntentTrigger = context.StringValue("DescribeNavigationConfig.SilenceTimeoutConfig.IntentTrigger");
			describeNavigationConfigResponse.SilenceTimeoutConfig = silenceTimeoutConfig;
        
			return describeNavigationConfigResponse;
        }
    }
}
