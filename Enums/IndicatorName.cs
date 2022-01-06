﻿using OoplesFinance.StockIndicators.Helpers;

namespace OoplesFinance.StockIndicators.Enums
{
    public enum IndicatorName
    {
        None,
        [Category(IndicatorType.Trend)]
        _1LCLeastSquaresMovingAverage,
        [Category(IndicatorType.Trend)]
        _3HMA,
        [Category(IndicatorType.Momentum)]
        _4MovingAverageConvergenceDivergence,
        [Category(IndicatorType.Momentum)]
        _4PercentagePriceOscillator,
        [Category(IndicatorType.Momentum)]
        AbsolutePriceOscillator,
        [Category(IndicatorType.Momentum)]
        AbsoluteStrengthIndex,
        [Category(IndicatorType.Trend)]
        AbsoluteStrengthMTFIndicator,
        [Category(IndicatorType.Momentum)]
        AcceleratorOscillator,
        [Category(IndicatorType.Volume)]
        AccumulationDistributionLine,
        [Category(IndicatorType.Momentum)]
        AccumulativeSwingIndex,
        [Category(IndicatorType.Trend)]
        AdaptiveAutonomousRecursiveMovingAverage,
        [Category(IndicatorType.Trend)]
        AdaptiveAutonomousRecursiveTrailingStop,
        [Category(IndicatorType.Momentum)]
        AdaptiveErgodicCandlestickOscillator,
        [Category(IndicatorType.Trend)]
        AdaptiveExponentialMovingAverage,
        [Category(IndicatorType.Trend)]
        AdaptiveLeastSquares,
        [Category(IndicatorType.Trend)]
        AdaptiveMovingAverage,
        [Category(IndicatorType.Volatility)]
        AdaptivePriceZoneIndicator,
        [Category(IndicatorType.Momentum)]
        AdaptiveRelativeStrengthIndex,
        [Category(IndicatorType.Momentum)]
        AdaptiveStochastic,
        [Category(IndicatorType.Trend)]
        AdaptiveTrailingStop,
        [Category(IndicatorType.Trend)]
        AhrensMovingAverage,
        [Category(IndicatorType.Trend)]
        AlligatorIndex,
        [Category(IndicatorType.Trend)]
        AlphaDecreasingExponentialMovingAverage,
        [Category(IndicatorType.Momentum)]
        AnchoredMomentum,
        [Category(IndicatorType.Momentum)]
        ApirineSlowRelativeStrengthIndex,
        [Category(IndicatorType.Trend)]
        ArnaudLegouxMovingAverage,
        [Category(IndicatorType.Trend)]
        AroonOscillator,
        [Category(IndicatorType.Momentum)]
        AsymmetricalRelativeStrengthIndex,
        [Category(IndicatorType.Trend)]
        AtrFilteredExponentialMovingAverage,
        [Category(IndicatorType.Volatility)]
        AutoDispersionBands,
        [Category(IndicatorType.Trend)]
        AutoFilter,
        [Category(IndicatorType.Trend)]
        AutoLine,
        [Category(IndicatorType.Trend)]
        AutoLineWithDrift,
        [Category(IndicatorType.Trend)]
        AutonomousRecursiveMovingAverage,
        [Category(IndicatorType.Momentum)]
        AverageAbsoluteErrorNormalization,
        [Category(IndicatorType.Trend)]
        AverageDirectionalIndex,
        [Category(IndicatorType.Momentum)]
        AverageMoneyFlowOscillator,
        [Category(IndicatorType.Volatility)]
        AverageTrueRange,
        [Category(IndicatorType.Volatility)]
        AverageTrueRangeChannel,
        [Category(IndicatorType.Trend)]
        AverageTrueRangeTrailingStops,
        [Category(IndicatorType.Momentum)]
        AwesomeOscillator,
        [Category(IndicatorType.Momentum)]
        BalanceOfPower,
        [Category(IndicatorType.Volatility)]
        BollingerBands,
        [Category(IndicatorType.Volume)]
        ChaikinMoneyFlow,
        [Category(IndicatorType.Volume)]
        ChaikinOscillator,
        [Category(IndicatorType.Trend)]
        ChandelierExit,
        [Category(IndicatorType.Momentum)]
        ChoppinessIndex,
        [Category(IndicatorType.Momentum)]
        CommodityChannelIndex,
        [Category(IndicatorType.Momentum)]
        ConnorsRelativeStrengthIndex,
        [Category(IndicatorType.SupportAndResistance)]
        DonchianChannels,
        [Category(IndicatorType.Trend)]
        EhlersMotherOfAdaptiveMovingAverages,
        [Category(IndicatorType.Momentum)]
        EhlersRoofingFilter,
        [Category(IndicatorType.Trend)]
        ElderRayIndex,
        [Category(IndicatorType.Trend)]
        EndPointMovingAverage,
        [Category(IndicatorType.Trend)]
        ExponentialMovingAverage,
        [Category(IndicatorType.Volume)]
        ForceIndex,
        [Category(IndicatorType.Volatility)]
        FractalChaosBands,
        [Category(IndicatorType.Trend)]
        FullTypicalPrice,
        [Category(IndicatorType.Momentum)]
        GatorOscillator,
        [Category(IndicatorType.Volatility)]
        HistoricalVolatility,
        [Category(IndicatorType.Trend)]
        HullMovingAverage,
        [Category(IndicatorType.Trend)]
        IchimokuCloud,
        [Category(IndicatorType.Momentum)]
        JapaneseCorrelationCoefficient,
        [Category(IndicatorType.Momentum)]
        JmaRsxClone,
        [Category(IndicatorType.Volatility)]
        JrcFractalDimension,
        [Category(IndicatorType.Trend)]
        JsaMovingAverage,
        [Category(IndicatorType.Trend)]
        JurikMovingAverage,
        [Category(IndicatorType.Trend)]
        KaufmanAdaptiveMovingAverage,
        [Category(IndicatorType.Volume)]
        KlingerVolumeOscillator,
        [Category(IndicatorType.Trend)]
        LeastSquaresMovingAverage,
        [Category(IndicatorType.Trend)]
        LinearRegression,
        [Category(IndicatorType.Trend)]
        MedianPrice,
        [Category(IndicatorType.Volume)]
        MoneyFlowIndex,
        [Category(IndicatorType.SupportAndResistance)]
        MovingAverageChannel,
        [Category(IndicatorType.Momentum)]
        MovingAverageConvergenceDivergence,
        [Category(IndicatorType.SupportAndResistance)]
        MovingAverageEnvelope,
        [Category(IndicatorType.Volume)]
        NegativeVolumeIndex,
        [Category(IndicatorType.Volume)]
        OnBalanceVolume,
        [Category(IndicatorType.Trend)]
        ParabolicSAR,
        [Category(IndicatorType.Momentum)]
        PercentagePriceOscillator,
        [Category(IndicatorType.Momentum)]
        PercentageVolumeOscillator,
        [Category(IndicatorType.Volume)]
        PositiveVolumeIndex,
        [Category(IndicatorType.Trend)]
        PoweredKaufmanAdaptiveMovingAverage,
        [Category(IndicatorType.SupportAndResistance)]
        PriceChannel,
        [Category(IndicatorType.Momentum)]
        PriceMomentumOscillator,
        [Category(IndicatorType.Momentum)]
        RateOfChange,
        [Category(IndicatorType.Momentum)]
        RelativeStrengthIndex,
        [Category(IndicatorType.Momentum)]
        SchaffTrendCycle,
        [Category(IndicatorType.Trend)]
        SimpleMovingAverage,
        [Category(IndicatorType.Volatility)]
        StandardDeviation,
        [Category(IndicatorType.Trend)]
        StandardDeviationChannel,
        [Category(IndicatorType.Volatility)]
        StandardDeviationVolatility,
        [Category(IndicatorType.SupportAndResistance)]
        StandardPivotPoints,
        [Category(IndicatorType.Momentum)]
        StochasticOscillator,
        [Category(IndicatorType.Volatility)]
        StollerAverageRangeChannels,
        [Category(IndicatorType.Trend)]
        SuperTrend,
        [Category(IndicatorType.Trend)]
        T3MovingAverage,
        [Category(IndicatorType.Trend)]
        TriangularMovingAverage,
        [Category(IndicatorType.Trend)]
        TripleExponentialMovingAverage,
        [Category(IndicatorType.Momentum)]
        Trix,
        [Category(IndicatorType.Momentum)]
        TrueStrengthIndex,
        [Category(IndicatorType.Trend)]
        TypicalPrice,
        [Category(IndicatorType.Volatility)]
        UlcerIndex,
        [Category(IndicatorType.Trend)]
        UltimateMovingAverage,
        [Category(IndicatorType.Momentum)]
        UltimateOscillator,
        [Category(IndicatorType.Trend)]
        VariableLengthMovingAverage,
        [Category(IndicatorType.Trend)]
        VolumeWeightedAveragePrice,
        [Category(IndicatorType.Trend)]
        VolumeWeightedMovingAverage,
        [Category(IndicatorType.Trend)]
        VortexIndicator,
        [Category(IndicatorType.Trend)]
        WeightedClose,
        [Category(IndicatorType.Trend)]
        WeightedMovingAverage,
        [Category(IndicatorType.Trend)]
        WellesWilderMovingAverage,
        [Category(IndicatorType.Momentum)]
        WilliamsR,
        [Category(IndicatorType.Volume)]
        ZDistanceFromVwap,
        [Category(IndicatorType.Momentum)]
        ZScore,
        [Category(IndicatorType.Trend)]
        ZeroLagExponentialMovingAverage,
        [Category(IndicatorType.Momentum)]
        ZeroLagSmoothedCycle,
        [Category(IndicatorType.Trend)]
        ZeroLagTripleExponentialMovingAverage,
        [Category(IndicatorType.Trend)]
        ZeroLowLagMovingAverage,
        [Category(IndicatorType.Momentum)]
        ZweigMarketBreadthIndicator
    }
}
