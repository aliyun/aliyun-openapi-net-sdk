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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeBoardSnapshotResponse : AcsResponse
	{

		private string requestId;

		private DescribeBoardSnapshot_Snapshot snapshot;

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

		public DescribeBoardSnapshot_Snapshot Snapshot
		{
			get
			{
				return snapshot;
			}
			set	
			{
				snapshot = value;
			}
		}

		public class DescribeBoardSnapshot_Snapshot
		{

			private DescribeBoardSnapshot_Board board;

			public DescribeBoardSnapshot_Board Board
			{
				get
				{
					return board;
				}
				set	
				{
					board = value;
				}
			}

			public class DescribeBoardSnapshot_Board
			{

				private string boardId;

				private string appUid;

				private long? eventTimestamp;

				private long? createTimestamp;

				private long? updateTimestamp;

				private List<DescribeBoardSnapshot_Page> pages;

				private List<DescribeBoardSnapshot_Config> configs;

				public string BoardId
				{
					get
					{
						return boardId;
					}
					set	
					{
						boardId = value;
					}
				}

				public string AppUid
				{
					get
					{
						return appUid;
					}
					set	
					{
						appUid = value;
					}
				}

				public long? EventTimestamp
				{
					get
					{
						return eventTimestamp;
					}
					set	
					{
						eventTimestamp = value;
					}
				}

				public long? CreateTimestamp
				{
					get
					{
						return createTimestamp;
					}
					set	
					{
						createTimestamp = value;
					}
				}

				public long? UpdateTimestamp
				{
					get
					{
						return updateTimestamp;
					}
					set	
					{
						updateTimestamp = value;
					}
				}

				public List<DescribeBoardSnapshot_Page> Pages
				{
					get
					{
						return pages;
					}
					set	
					{
						pages = value;
					}
				}

				public List<DescribeBoardSnapshot_Config> Configs
				{
					get
					{
						return configs;
					}
					set	
					{
						configs = value;
					}
				}

				public class DescribeBoardSnapshot_Page
				{

					private int? pageIndex;

					private List<DescribeBoardSnapshot_Element> elements;

					public int? PageIndex
					{
						get
						{
							return pageIndex;
						}
						set	
						{
							pageIndex = value;
						}
					}

					public List<DescribeBoardSnapshot_Element> Elements
					{
						get
						{
							return elements;
						}
						set	
						{
							elements = value;
						}
					}

					public class DescribeBoardSnapshot_Element
					{

						private string elementIndex;

						private string ownerId;

						private int? elementType;

						private long? updateTimestamp;

						private string data;

						public string ElementIndex
						{
							get
							{
								return elementIndex;
							}
							set	
							{
								elementIndex = value;
							}
						}

						public string OwnerId
						{
							get
							{
								return ownerId;
							}
							set	
							{
								ownerId = value;
							}
						}

						public int? ElementType
						{
							get
							{
								return elementType;
							}
							set	
							{
								elementType = value;
							}
						}

						public long? UpdateTimestamp
						{
							get
							{
								return updateTimestamp;
							}
							set	
							{
								updateTimestamp = value;
							}
						}

						public string Data
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
					}
				}

				public class DescribeBoardSnapshot_Config
				{

					private string appUid;

					private string data;

					public string AppUid
					{
						get
						{
							return appUid;
						}
						set	
						{
							appUid = value;
						}
					}

					public string Data
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
				}
			}
		}
	}
}
